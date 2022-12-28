using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//체력 표시
public class Heart5 : MonoBehaviour
{
    public Transform target;

    void LateUpdate()
    {
        transform.position = new Vector3(target.position.x - 5f, target.position.y + 4f);
    }
}
