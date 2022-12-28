using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport4 : MonoBehaviour
{
    public string targetObjectName;

    GameObject targetObject;

    void Start()
    {
        targetObject = GameObject.Find(targetObjectName);

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            targetObject.transform.position = new Vector3(364.18f, -210f, 0);
        }
    }
}
