using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Material : MonoBehaviour
{
    public GameObject Object;

    // Update is called once per frame
    void Update()
    {
        
    }

    

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {

            Instantiate(Object);
        }
    }
}
