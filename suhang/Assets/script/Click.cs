using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Click : MonoBehaviour
{

    public void Cl()
    {
        SceneManager.LoadScene("Story");
        
    }

    public void F()
    {
        GameManager.Stc = 0;
        GameManager.Scn = 0;
        SceneManager.LoadScene("Main");
     
    }

    public void H()
    {
        SceneManager.LoadScene("How");
    }

   
  

  
}
