using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float Speed = 1;
    public float rotAngleZ = 45;

   

    public Transform Wing1;
    public Transform Wing2;

    private void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        float rZ1 = Mathf.SmoothStep(0, rotAngleZ, Mathf.PingPong(Time.time * Speed, 1));
        float rZ2 = Mathf.SmoothStep(0, -rotAngleZ, Mathf.PingPong(Time.time * Speed, 1));

        

        Wing1.transform.rotation = Quaternion.Euler(0, 0, rZ1);
        Wing2.transform.rotation = Quaternion.Euler(0, 0, rZ2);

    }
}
