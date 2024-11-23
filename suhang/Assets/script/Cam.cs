using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public GameObject cam;
    public GameObject par;


    private void OnTriggerStay2D(Collider2D collision)
    {
        cam.transform.position = new Vector3(40.5f, transform.position.y, transform.position.z);
        par.transform.position = new Vector3(40f, -1f, transform.position.z);

    }
}
