using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//���ȭ�� ������
public class BG_Move : MonoBehaviour
{
    public Transform target;

    void LateUpdate()
    {
        transform.position = new Vector3(target.position.x, target.position.y, 10f);
    }
}
