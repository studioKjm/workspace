using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//카메라 이동
public class MoveCamera : MonoBehaviour
{
    public Transform target;
    
    void LateUpdate()
    {
        transform.position = new Vector3(target.position.x, target.position.y, -10f);
    }
}
