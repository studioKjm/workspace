using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public string showObjectName1;

    GameObject showObject1;

    public GameObject newPrefab;
    public int maxCount = 20;

    public float throwX = 4;
    public float throwy = 8;
    public float offsetY = 1;

    bool pushFlag = false;
    bool leftFlag = false;

    void Start()
    {

        showObject1 = GameObject.Find(showObjectName1);

    }

        void Update()
    {
    
        if(Input.GetKey("right"))
        {
            leftFlag = false;
        }
        if (Input.GetKey("left"))
        {
            leftFlag = true;
        }
        if (Input.GetKey("q") && (showObject1.activeSelf == false))
        {
            if(pushFlag == false)
            {
                pushFlag = true;

                Vector3 area = this.GetComponent<SpriteRenderer>().bounds.size;
                Vector3 newPos = this.transform.position;
                if (leftFlag)
                {
                    newPos.x = this.transform.position.x - 1f;
                }
                else
                {
                    newPos.x = this.transform.position.x + 1f;
                }
                newPos.y = this.transform.position.y;

                GameObject newGameObject = Instantiate(newPrefab) as GameObject;
                newPos.z = -5;
                newGameObject.transform.position = newPos;

                Rigidbody2D rbody = newGameObject.GetComponent<Rigidbody2D>();

                if(leftFlag)
                {
                    rbody.AddForce(new Vector2(-throwX, 0), ForceMode2D.Impulse);
                    
                }
                else
                {
                    rbody.AddForce(new Vector2(throwX, 0), ForceMode2D.Impulse);
                }


            }
            

            

        }

        else
        {
            pushFlag = false;
        }

    }

}
