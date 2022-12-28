using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//¸®½ºÆù
public class Back_stage3 : MonoBehaviour
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
            targetObject.transform.position = new Vector3(361.51f, -48f, 0);
        }
    }
}
