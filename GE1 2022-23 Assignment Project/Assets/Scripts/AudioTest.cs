using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AudioTest : MonoBehaviour
{
    public float scale = 10;
    List<GameObject> elements = new List<GameObject>();
    // Use this for initialization
    void Start()
    {
        CreateVisualisers();

    }

    public float radius = 50;

    void CreateVisualisers()
    {
        /*
        float theta = (Mathf.PI * 2.0f) / (float)AudioManager.frameSize;
        for (int i = 0; i < AudioManager.frameSize; i++)
        {
            Vector3 p = new Vector3(
                Mathf.Sin(theta * i) * radius
                , 0
                , Mathf.Cos(theta * i) * radius
                );
            p = transform.TransformPoint(p);
            Quaternion q = Quaternion.AngleAxis(theta * i * Mathf.Rad2Deg, Vector3.up);
            q = transform.rotation * q;

            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.SetPositionAndRotation(p, q);
            cube.transform.parent = this.transform;
            cube.GetComponent<Renderer>().material.color = Color.HSVToRGB(
                i / (float)AudioManager.frameSize
                , 1
                , 1
                );
            elements.Add(cube);
        }*/
    }

    
    void Update()
    {
        for (int i = 0; i < elements.Count; i++)
        {
            elements[i].transform.localScale = new Vector3(1, 1 + AudioManager.Instance.spectrum[i] * scale, 1);
        }
       /* for (int i = 0; i < elements.Count; i++)
        {

        
            transform.localScale = new Vector3(1, AudioManager.Instance.spectrum[i] * scale, 1);
    }*/
}
}
