using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//���� �ݺ��
public class Up5 : MonoBehaviour
{
    float upMax = 6.0f;

    float downMax = -2.0f;

    float currentPosition;

    float direction = 3.0f;

    void Start()
    {

        currentPosition = transform.position.y;

    }

    void Update()
    {
        currentPosition += Time.deltaTime * direction;

        if (currentPosition >= upMax)
        {
            direction *= -1;

            currentPosition = upMax;
        }
        else if (currentPosition <= downMax)
        {
            direction *= -1;

            currentPosition = downMax;
        }

        transform.position = new Vector3(36, currentPosition - 24, 0);
    }
}