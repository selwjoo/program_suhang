using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.Mathematics;
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

    public float timer = 0.5f;
    private bool istime = true;
    private bool isGrounded = true;

    public SpriteRenderer ren;
    public GameObject player;
    public Animator animator;


    // Start is called before the first frame update

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ren = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame


    void Update()
    {
        move();
        gravity_fly();

        if (isG1 == true)
        {
            Quaternion targetRotation = Quaternion.Euler(new Vector3(0, 0, 180));
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 5);
        }
        else
        {
            Quaternion targetRotation = Quaternion.Euler(new Vector3(0, 0, 0));
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 5);
        }


    }

    void move()
    {

        float x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(x * speed, rb.velocity.y);


        if (x > 0)
        {
            ren.flipX = false;

            if(isGrounded == true)
            {
                animator.SetBool("isrun", true);
            }
            
        }
        else if (x < 0)
        {
            ren.flipX = true;

            if (isGrounded == true)
            {
                animator.SetBool("isrun", true);
            }
     
        }

        if (x == 0)
        {
            if (isGrounded == true)
            {
                animator.SetBool("isrun", false);
            }

 
        }
    }

    void gravity_fly()
    {

        if (Input.GetMouseButtonDown(1) && istime)
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
        isG1 = !isG1; // ��Ŭ�� �������� �ٷ� �߷��� �ٷ� ������� �Ǵ°� �������� 이거 왜이럼?

        ren.flipX = true;

        rb.gravityScale *= -1;

        istime = false;

        yield return new WaitForSeconds(timer);

        istime = true;

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

            if (GameManager.Scn == 0)
            {
                SceneManager.LoadScene("Story 1");
            }
            else if(GameManager.Scn == 1)
            {
                SceneManager.LoadScene("1");
            }
            else if(GameManager.Scn == 2)
            {
                SceneManager.LoadScene("2");
            }
            else if (GameManager.Scn == 3)
            {
                SceneManager.LoadScene("3");
            }
            else if (GameManager.Scn == 4)
            {
                SceneManager.LoadScene("4");
            }
            else if (GameManager.Scn == 5)
            {
                SceneManager.LoadScene("5");
            }
            else if (GameManager.Scn == 6)
            {
                SceneManager.LoadScene("6");
            }
            GameManager.Scn += 1;

        }
        if (collision.gameObject.CompareTag("door1"))
        {
            SceneManager.LoadScene("Ending");
        }

        if (collision.gameObject.CompareTag("story"))
        {
            collision.collider.isTrigger = true;
            SceneManager.LoadScene("Story 1");
        }

        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            animator.SetBool("isfall", false);
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
            animator.SetBool("isfall", true);
        }
    }


}
