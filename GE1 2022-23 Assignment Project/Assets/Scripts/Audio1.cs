using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Audio1 : MonoBehaviour
{
    public float scale = 10;

    public GameObject[] scaleObjects;

    void Update()
    {
        for (int i = 0; i < 10; i++)
        {
            // this.gameObject.transform.localScale = new Vector3(1 + AudioManager.Instance.spectrum[i] * scale, 1 + AudioManager.Instance.spectrum[i] * scale, 1 + AudioManager.Instance.spectrum[i] * scale);
            Vector3 ls = scaleObjects[i].transform.localScale;
            ls.x = Mathf.Lerp(ls.x, 1 + (AudioManager.Instance.spectrum[i] * scale), Time.deltaTime * 3f);
            ls.y = Mathf.Lerp(ls.y, 1 + (AudioManager.Instance.spectrum[i] * scale), Time.deltaTime * 3f);
            ls.z = Mathf.Lerp(ls.z, 1 + (AudioManager.Instance.spectrum[i] * scale), Time.deltaTime * 3f);


            foreach (GameObject scaleObjects in scaleObjects)
            {
                scaleObjects.transform.localScale = ls;
            }
            

        }


    }
}
