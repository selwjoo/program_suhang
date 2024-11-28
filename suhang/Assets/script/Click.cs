using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Click : MonoBehaviour
{
    public void Cl()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void F()
    {
        SceneManager.LoadScene("Main");
    }
}
