using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Transform Player;

    void LateUpdate()
    {
        transform.LookAt(transform.position + Player.forward);
    }
}
