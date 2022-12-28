using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//ÇÁ¸®ÆÕ »ý¼º
public class OnCollision_Makeprefab : MonoBehaviour
{
    public GameObject newPrefab;
    public string targetObjectName;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            Vector3 area = GetComponent<SpriteRenderer>().bounds.size;
            Vector3 newPos = new Vector3(59.15f, -142.40f, 0);
            GameObject newGameObject = Instantiate(newPrefab) as GameObject;
            newGameObject.transform.position = newPos;
        }
    }
}


