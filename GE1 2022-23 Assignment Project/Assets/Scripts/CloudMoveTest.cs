using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMoveTest : MonoBehaviour
{
    public float Speed = 10f;
    
    void Update()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
    }
}
