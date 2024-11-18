using JetBrains.Rider.Unity.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Particle : Player
{
    // Start is called before the first frame update
    public ParticleSystem P;

    // Update is called once per frame
    void Update()
    {
        control();
        C1();
    }


    public void control()
    {
        if(isG1 == true)
        {
          
            P.transform.rotation = Quaternion.Euler(200,0, 0);
        }
        else
        {
         
            P.transform.rotation = Quaternion.Euler(20,0,0);
        }
    }

    public void C1()
    {

        if (Input.GetMouseButtonDown(1))
        {
            isG1 = !isG1;
        }
    }
}
