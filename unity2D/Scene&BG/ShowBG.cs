using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//배경화면 활성화
public class ShowBG : MonoBehaviour
{
    public string targetObjectName;
    public string showObjectName;
    GameObject showObject;

    void Start()
    {
        showObject = GameObject.Find(showObjectName);
        showObject.SetActive(false);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            showObject.SetActive(true);
        }
    }
}
