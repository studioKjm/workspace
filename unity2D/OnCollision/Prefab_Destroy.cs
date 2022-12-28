using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prefab_Destroy : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("platform"))
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag.Equals("Player"))
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag.Equals("enemy"))
        {
            Destroy(this.gameObject);
        }
    }  
}
