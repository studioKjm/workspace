using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timeout_Destroy : MonoBehaviour
{
    public float liminSec = 3;

    void Start()
    {

        Destroy(this.gameObject, liminSec);
        
    }
}
