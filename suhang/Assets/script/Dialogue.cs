using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Dialog
{
    [TextArea]
    public string dialogue;
    public Sprite pic;

}
public class Dialogue : MonoBehaviour
{
    [SerializeField] private Dialog[] dialogue;

    [SerializeField] private Text TD;

    [SerializeField] private SpriteRenderer Pics;

    private int count = 0;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(count < dialogue.Length)  NextD();   
        }

       
    }

    public void ShowD()
    {
        count = 0;
        NextD();

    }

    public void NextD()
    {
        TD.text = dialogue[count].dialogue;
        Pics.sprite = dialogue[count].pic;
        count++;
    }



}
