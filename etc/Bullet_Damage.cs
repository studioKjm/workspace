using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//�Ѿ� ������
public class Bullet_Damage : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("enemy"))
        {
            Destroy(collision.gameObject);         
        }
        Destroy(this.gameObject);
    }
}
