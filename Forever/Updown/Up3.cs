using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//상하 반복운동
public class Up3 : MonoBehaviour
{
    float upMax = 4.0f;

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

        transform.position = new Vector3(28, currentPosition - 22, 0);
    }
}
