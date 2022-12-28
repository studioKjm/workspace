using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//2&3번째 카드키
public class OtherKey : MonoBehaviour
{
    public string targetObjectName;
    public string showObjectName1;
    public string showObjectName2;
    GameObject showObject1;
    GameObject showObject2;

    void Start()
    {
        showObject1 = GameObject.Find(showObjectName1);     
        showObject2 = GameObject.Find(showObjectName2);
        showObject2.SetActive(true);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            showObject1.SetActive(true);
            showObject2.SetActive(false);
        }
    }
}
