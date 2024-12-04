using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : MonoBehaviour
{
    public GameObject player;
    private bool isG1;

    // Update is called once per frame
    void Update()
    {
        Vector3 targetposition = new Vector3(player.transform.position.x -1, player.transform.position.y ,0);
        transform.position = Vector3.Lerp(transform.position,targetposition, Time.deltaTime *4f );

        if (isG1 == true)
        {
            Quaternion targetRotation = Quaternion.Euler(new Vector3(0, 0, -180));
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 5);
        }
        else
        {
            Quaternion targetRotation = Quaternion.Euler(new Vector3(0, 0, 0));
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 5);
        }

        if (Input.GetMouseButtonDown(1))
        {
            StartCoroutine(G1());
           
        }
    }

    public IEnumerator G1()
    {
        isG1 = !isG1; // ��Ŭ�� �������� �ٷ� �߷��� �ٷ� ������� �Ǵ°� �������� 이거 왜이럼?

        yield return null;


    }

}
