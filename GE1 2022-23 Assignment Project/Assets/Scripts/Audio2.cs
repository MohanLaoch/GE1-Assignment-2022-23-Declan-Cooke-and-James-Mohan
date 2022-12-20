using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio2 : MonoBehaviour
{
    public float scale = 10;


    void Update()
    {
        for (int i = 0; i < 10; i++)
        {
            Vector3 ls = this.transform.localScale;
            //ls.x = Mathf.Lerp(ls.x, 1 + (AudioManager.Instance.spectrum[i] * scale), Time.deltaTime * 3f);
            ls.y = Mathf.Lerp(ls.y, 1 + (AudioManager.Instance.spectrum[i] * scale), Time.deltaTime * 3f);
            //ls.z = Mathf.Lerp(ls.z, 1 + (AudioManager.Instance.spectrum[i] * scale), Time.deltaTime * 3f);


            this.transform.localScale = ls;


        }


    }
}
