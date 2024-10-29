using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    SpriteRenderer rend;

    bool gravity_con;
    //start
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gravity_con = false;
    }
   
    //update
    void Update()
    {
        move();
        jump();
    }

   //충돌 감지
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("floor")) 
        {
            isGrounded = true;
        }
        if (collision.gameObject.CompareTag("gravitas"))
        {
            gravity_con = true;
            antigravity();

        }
    }

    //이동
    public float move_speed=5f;
    void move()
    {
        float horizontal = Input.GetAxis("Horizontal");

        Vector2 position = transform.position;

        position.x += horizontal * Time.deltaTime * move_speed;

        transform.position = position;
    }

    //점프
    bool isGrounded;
   
    public float jump_force = 50f;
    private Rigidbody2D rb;
    void jump()
    {
        if (isGrounded==true && Input.GetKeyDown(KeyCode.Space))
        {
            if (rb.gravityScale > 0)
            {
                rb.AddForce(Vector2.up * jump_force, ForceMode2D.Impulse);
            }
            else if(rb.gravityScale < 0)
            {
                rb.AddForce(Vector2.down * jump_force, ForceMode2D.Impulse);
            }
            
        }
    }

    //활공-우산
    void fly()
    {
        if (gravity_con == false && Input.GetKey(KeyCode.E))
        {
            rb.drag -= 2;
        }
    }

    //상호작용-gravitas
    void antigravity()
    {
        if(gravity_con == true)
        {
            rb = GetComponent<Rigidbody2D>();
            rb.gravityScale *= -1;
        }
    }
}
