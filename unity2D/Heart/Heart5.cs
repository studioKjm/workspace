using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//ü�� ǥ��
public class Heart5 : MonoBehaviour
{
    public Transform target;

    void LateUpdate()
    {
        transform.position = new Vector3(target.position.x - 5f, target.position.y + 4f);
    }
}
