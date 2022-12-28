using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport2 : MonoBehaviour
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
            targetObject.transform.position = new Vector3(90, -40, 0);

            GameObject hideObject = GameObject.Find(hideObjectName);
            hideObject.SetActive(false);
        }
    }
}
