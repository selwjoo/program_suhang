using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class meteorite : MonoBehaviour
{
    // Start is called before the first frame update

    private int count = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            count++;
        }

        if(count >= 2 && GameManager.Stc == 0)
        {
            Vector3 targetposition = new Vector3(20, -2, 0);
            transform.position = Vector3.MoveTowards(transform.position, targetposition, Time.deltaTime * 25);
        }

        if (count == 20 && GameManager.Stc == 0)
        {
            GameManager.Stc += 1;
            SceneManager.LoadScene("Tutorial");
        }

        if(count == 9 && GameManager.Stc == 1)
        {
            GameManager.Stc += 1;
            SceneManager.LoadScene("Tutorial 1");
        }

        if (count == 16 && GameManager.Stc == 2)
        {
            GameManager.Stc += 1;
            SceneManager.LoadScene("Ending2");
        }

        if (count == 6 && GameManager.Stc == 3)
        {
            SceneManager.LoadScene("Ending3");
        }

    }
}
