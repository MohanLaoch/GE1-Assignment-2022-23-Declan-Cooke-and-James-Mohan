using UnityEngine;
using UnityEngine.XR.Management;

public class DetectVR : MonoBehaviour // remove MonoBehaviour if building with multiple scenes
{
    public bool startInVR = true;

    public GameObject xrOrigin;
    public GameObject desktopCharacter;

    void Start()
    {
        if (startInVR)
        {
            // checks if VR headset is connected

            var xrSettings = XRGeneralSettings.Instance;
            if (xrSettings == null)
            {
                Debug.Log("XRGeneralSettings is null");
                return;
            }

            var xrManager = xrSettings.Manager;
            if (xrManager == null)
            {
                Debug.Log("XRManagerSettings is null");
                return;
            }

            var xrLoader = xrManager.activeLoader;
            if (xrLoader == null)
            {
                Debug.Log("XRLoader is null");

                // set the XR camera to false & set the desktop camera to true if there is no VR headset when start in VR is set to true
                DesktopCharacterOn();
                return;
            }

            Debug.Log("XRLoader is NOT null");

            // if there is a VR headset connected set the XR camera to true & set the desktop camera to false
            xrOrigin.SetActive(true);
            desktopCharacter.SetActive(false);
        }
        else
        {
            // set the XR camera to false & set the desktop camera to true
            DesktopCharacterOn();
        }

    }

    void DesktopCharacterOn()
    {
        xrOrigin.SetActive(false);
        desktopCharacter.SetActive(true);
    }

}
