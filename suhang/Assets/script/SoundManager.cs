using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource bgm;
    private static SoundManager instance;  // �̱��� �ν��Ͻ��� ������ ����

    private void Awake()
    {
        // �̹� �ν��Ͻ��� �����ϴ��� üũ
        if (instance != null)
        {
            // ���� �ν��Ͻ��� �ִٸ� ���� ������Ʈ�� �ı�
            Destroy(gameObject);
        }
        else
        {
            // �ν��Ͻ��� ���ٸ� ���� ������Ʈ�� �̱������� �����ϰ� DontDestroyOnLoad�� ����
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start()
    {
        // ������� ���
        bgm.Play();
    }
}

