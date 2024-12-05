using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject Object;
    // Start is called before the first frame update

    public void D()
    {
        Destroy(Object);
    }
    


    public void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(Object);
    }

}
