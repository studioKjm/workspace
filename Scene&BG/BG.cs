using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//배경화면 움직임
public class BG_Move : MonoBehaviour
{
    public Transform target;

    void LateUpdate()
    {
        transform.position = new Vector3(target.position.x, target.position.y, 10f);
    }
}
