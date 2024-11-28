using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveblock2 : MonoBehaviour
{
    public float ud2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + ud2, transform.position.y , transform.position.z);
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("crash"))
        {
            ud2 *= -1;

        }
    }
}
