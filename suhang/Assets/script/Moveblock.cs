using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveblock : MonoBehaviour
{
 
    public float ud ;
  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = new Vector3(transform.position.x, transform.position.y + ud, transform.position.z);
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("crash"))
        {
            ud *= -1;
           
        }
    }

 

}
