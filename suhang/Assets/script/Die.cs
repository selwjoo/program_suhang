using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour
{
    public GameObject player;
    
    void Update()
    {
        D();
    }

    public void D()
    {
        if(player.transform.position.y <= -10)
        {
            Destroy(player);
            Debug.Log("ав╬З╢ы.");
            SceneManager.LoadScene("Die");
        }
    }

  
}
