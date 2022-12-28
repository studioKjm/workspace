using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//적과 충돌할 경우
public class TagEnemy : MonoBehaviour
{
    public int count = 0;
    public int maxcount = 1000;
    public string sceneName;
    public string showObjectName1;
    public string showObjectName2;
    public string showObjectName3;
    public string showObjectName4;
    public string showObjectName5;
    public string bloodName;
    public static float counto = 0;
    GameObject showObject1;
    GameObject showObject2;
    GameObject showObject3;
    GameObject showObject4;
    GameObject showObject5;
    GameObject blood;

    void Start()
    {
        showObject1 = GameObject.Find(showObjectName1);
        showObject1.SetActive(true);
        showObject2 = GameObject.Find(showObjectName2);
        showObject2.SetActive(true);
        showObject3 = GameObject.Find(showObjectName3);
        showObject3.SetActive(true);
        showObject4 = GameObject.Find(showObjectName4);
        showObject4.SetActive(true);
        showObject5 = GameObject.Find(showObjectName5);
        showObject5.SetActive(true);
        blood = GameObject.Find(bloodName);
        blood.SetActive(false);
        counto = 0;
    }
    void Update()
    {
        if(blood.activeSelf==true)
        {
            count += 1;
        }
        if (count >= maxcount)
        {
            blood.SetActive(false);
            count = 0;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("enemy"))
        {
            showObject1.SetActive(false);
            counto = counto + 1;
            blood.SetActive(true);
        }
        if ((collision.gameObject.tag.Equals("enemy")) && (showObject2.activeSelf == true) && (showObject1.activeSelf == false) && (counto >= 2))
        {
            showObject2.SetActive(false);
            counto = counto + 1;
            blood.SetActive(true);
        }
        if ((collision.gameObject.tag.Equals("enemy")) && (showObject3.activeSelf == true) && (showObject2.activeSelf == false) && (counto >= 4))
        {
            showObject3.SetActive(false);
            counto = counto + 1;
            blood.SetActive(true);
        }

        if ((collision.gameObject.tag.Equals("enemy")) && (showObject4.activeSelf == true) && (showObject3.activeSelf == false) && (counto >= 6))
        {
            showObject4.SetActive(false);
            counto = counto + 1;
            blood.SetActive(true);
        }
        if ((collision.gameObject.tag.Equals("enemy")) && (showObject5.activeSelf == true) && (showObject4.activeSelf == false) && (counto >= 8))
        {
            showObject5.SetActive(false);
            SceneManager.LoadScene(sceneName);
        }
    }
}
