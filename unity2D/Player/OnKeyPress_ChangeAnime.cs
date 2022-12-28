using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//플레이어 애니메이션 변환
public class OnKeyPress_ChangeAnime : MonoBehaviour
{
    public string runAnime = "";
    public string jumpAnime = "";
    public string idleAnime = "";
    public string hurtAnime = "";
    public string shootAnime = "";
    string oldMode = "";
    string nowMode = "";
    Rigidbody2D rbody;
    SpriteRenderer render;

    void Start()
    {
        nowMode = idleAnime;
        rbody = GetComponent<Rigidbody2D>();
        render = GetComponent<SpriteRenderer>();
    }
    void Update()
    {           
        if (Input.GetKey("space"))
        {
            nowMode = jumpAnime;
        }
        if (Input.GetKey("right"))
        {
            nowMode = runAnime;
        }
        if (Input.GetKey("left"))
        {
            nowMode = runAnime;
        }
        if (Input.GetKeyUp("left"))
        {
            nowMode = idleAnime;
        }
        if (Input.GetKeyUp("right"))
        {
            nowMode = idleAnime;
        }
        if (Input.GetKeyUp("q"))
        {
            nowMode = shootAnime;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("enemy"))
        {
            nowMode = hurtAnime;
            OnDamaged(collision.transform.position);
        }
    }
    void OnDamaged(Vector2 targetPos)
    {
        gameObject.layer = 11;
        render.color = new Color(1, 1, 1, 0.4f);   
        int dirc = transform.position.x - targetPos.x > 0 ? 1 : -1;
        rbody.AddForce(new Vector2(dirc, 1) * 7, ForceMode2D.Impulse);
        Invoke("OffDamaged", 3);
    }

    void OffDamaged()
    {
        gameObject.layer = 5;
        render.color = new Color(1, 1, 1, 1);
    }

    void FixedUpdate()
    {
        if(nowMode != oldMode)
        {          
            Animator animator = this.GetComponent<Animator>();
            animator.Play(nowMode);
        }       
    }
}
