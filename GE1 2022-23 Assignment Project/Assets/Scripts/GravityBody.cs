using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityBody : MonoBehaviour
{
    public GravityAttractor attractor;
    private Transform myTransform;




    void Awake()
    {
        if (attractor == null)
        {
            attractor = GameObject.Find("Planet").GetComponent<GravityAttractor>();
        }

        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        GetComponent<Rigidbody>().useGravity = false;
        myTransform = transform;
    }

    void Update()
    {
       
        
            attractor.Attract(myTransform);

        
    }
}
