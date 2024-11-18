using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Revival : Player
{
    
    // Update is called once per frame
    void Update()
    {
        R();
    }

    public void R()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(Scn == 0)
            {
                SceneManager.LoadScene("Tutorial");
            }
            else if(Scn == 1)
            {
                SceneManager.LoadScene("1");
            }
            else if (Scn == 2)
            {
                SceneManager.LoadScene("2");
            }
          
           

        }
    }

}
