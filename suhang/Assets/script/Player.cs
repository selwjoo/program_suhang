using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float speed = 2f;
    private Rigidbody2D rb;
    [SerializeField]
    protected bool isG1 = false;
    private int count = 0;
    public int limit = 3;
    protected int Scn = 0;

    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
        gravity_fly();

    }

    void move()
    {

        float x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(x * speed, rb.velocity.y);
       
    }

    void gravity_fly()
    {

        if (Input.GetMouseButtonDown(1))
        {
            count += 1;
            if(count <=limit)
            {
                StartCoroutine(G1());
            }
            

        }
       

        if (Input.GetMouseButton(0))
        {
            
            if(isG1 == false)
            {
                rb.gravityScale = 0.2f; 
            }
            else if (isG1 == true)
            {
                rb.gravityScale = -0.2f;
            }


        }
        else if (isG1 == false)
        {
            rb.gravityScale = 2f;
        }
        else if (isG1 == true)
        {
            rb.gravityScale = -2f;
        }

    }

    public IEnumerator G1()
    {
        isG1 = !isG1; // 우클릭 눌렀을때 바로 중력이 바로 원래대로 되는거 막으려고

        rb.gravityScale *= -1;

        yield return null;


    }

 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Die"))
        {
            Destroy(player);
            SceneManager.LoadScene("Die");
        }
        if (collision.gameObject.CompareTag("bdbd"))
        {
            Destroy(collision.gameObject, 1f);
        }

        if (collision.gameObject.CompareTag("door"))
        {

            if (Scn == 0)
            {
                SceneManager.LoadScene("1");
            }
            else if(Scn == 1)
            {
                SceneManager.LoadScene("2");
            }
            else if(Scn == 2)
            {
                SceneManager.LoadScene("3");
            }
        }

    }

    
}
