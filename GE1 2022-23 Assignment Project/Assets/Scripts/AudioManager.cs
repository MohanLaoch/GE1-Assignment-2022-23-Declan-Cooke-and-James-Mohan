using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{

    public bool useMic = false;
    public AudioClip clip;
    AudioSource a;
    public AudioMixerGroup amgMic;
    public AudioMixerGroup amgMaster;

    public string selectedDevice;

    public static int frameSize = 512;
    public float[] spectrum;
    public float[] samples;

    public float[] bands;

    public float binWidth;
    public float sampleRate;

    public static AudioManager Instance;


    private void Awake()
    {
        StartCoroutine(Awake1());
    }

    IEnumerator Awake1()
    {
        Instance = this;
        a = GetComponent<AudioSource>();
        spectrum = new float[frameSize];
        samples = new float[frameSize];
        bands = new float[(int)Mathf.Log(frameSize, 2)];

        if (useMic)
        {
            foreach (string s in Microphone.devices)
            {
                Debug.Log(s);
            }
            if (Microphone.devices.Length > 0)
            {
                selectedDevice = Microphone.devices[0].ToString();
                Debug.Log("Setting device to: " + selectedDevice);
                a.clip = Microphone.Start(selectedDevice, true, 1, AudioSettings.outputSampleRate);
                //a.outputAudioMixerGroup = amgMic;
            }
        }
        else
        {
            a.clip = clip;
            a.outputAudioMixerGroup = amgMaster;
        }

        while (Microphone.GetPosition(selectedDevice) == 0)
        {
            //Debug.Log("Yielding");
            yield return null;
        }
        //Debug.Log("Playing");
        a.Play();
    }

    // Use this for initialization
    void Start()
    {
        sampleRate = AudioSettings.outputSampleRate;
        binWidth = AudioSettings.outputSampleRate / 2 / frameSize;

        fSample = AudioSettings.outputSampleRate;
    }

   


    // From: https://answers.unity.com/questions/157940/getoutputdata-and-getspectrumdata-they-represent-t.html
    public float rmsValue = 0;
    public float dbValue = 0;
    public float refValue = 0.1f;
    public float threshold = 0.02f;
    public float pitchValue = 0;
    private float fSample;

    void AnalyzeSound()
    {
        a.GetOutputData(samples, 0); // fill array with samples
        int i;
        float sum = 0;
        for (i = 0; i < frameSize; i++)
        {
            sum += samples[i] * samples[i]; // sum squared samples
        }
        rmsValue = Mathf.Sqrt(sum / frameSize); // rms = square root of average
        dbValue = 20 * Mathf.Log10(rmsValue / refValue); // calculate dB
        if (dbValue < -160) dbValue = -160; // clamp it to -160dB min
                                            // get sound spectrum
        a.GetSpectrumData(spectrum, 0, FFTWindow.BlackmanHarris);
        float maxV = 0;
        int maxN = 0;
        for (i = 0; i < frameSize; i++)
        { // find max 
            if (spectrum[i] > maxV && spectrum[i] > threshold)
            {
                maxV = spectrum[i];
                maxN = i; // maxN is the index of max
            }
        }
        float freqN = maxN; // pass the index to a float variable
        if (maxN > 0 && maxN < frameSize - 1)
        { // interpolate index using neighbours
            var dL = spectrum[maxN - 1] / spectrum[maxN];
            var dR = spectrum[maxN + 1] / spectrum[maxN];
            freqN += 0.5f * (dR * dR - dL * dL);
        }
        pitchValue = freqN * (fSample / 2) / frameSize; // convert index to frequency
    }

    void GetFrequencyBands()
    {
        for (int i = 0; i < bands.Length; i++)
        {
            int start = (int)Mathf.Pow(2, i) - 1;
            int width = (int)Mathf.Pow(2, i);
            int end = start + width;
            float average = 0;
            for (int j = start; j < end; j++)
            {
                average += spectrum[j] * (j + 1);
            }
            average /= (float)width;
            bands[i] = average;
            // Debug.Log(i + "\t" + start + "\t" + end + "\t" + start * binWidth + "\t" + (end * binWidth));
        }

    }


    // Update is called once per frame
    void Update()
    {
        AnalyzeSound();
        GetFrequencyBands();
    }
}