using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//반복되는 배경화면
public class RepeatBG : MonoBehaviour
{
    [SerializeField] [Range(0.5f, 0.5f)] float speed = 3f;
    [SerializeField] float posValue;
    Vector2 startPos;
    float newPos;

    void Start()
    {
        startPos = transform.position;
    }
    void Update()
    {
        newPos = Mathf.Repeat(-Time.time * speed/3, posValue);
        transform.position = startPos + Vector2.right * newPos;
    }
}
