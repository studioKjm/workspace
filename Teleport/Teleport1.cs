using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//1스테이지에서 2스테이지로 이동
public class Teleport1 : MonoBehaviour
{
    public string targetObjectName;
    public string showObjectName1;
    public string hideObjectName;
    GameObject targetObject;
    GameObject showObject1;
    
    void Start()
    {
        targetObject = GameObject.Find(targetObjectName);
        showObject1 = GameObject.Find(showObjectName1);        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName && showObject1.activeSelf == false)
        {
            targetObject.transform.position = new Vector3(80, -8, 0);
            GameObject hideObject = GameObject.Find(hideObjectName);
            hideObject.SetActive(false);
        }
    }
}
