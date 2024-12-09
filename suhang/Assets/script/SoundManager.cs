using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource bgm;
    private static SoundManager instance;  // 싱글톤 인스턴스를 저장할 변수

    private void Awake()
    {
        // 이미 인스턴스가 존재하는지 체크
        if (instance != null)
        {
            // 기존 인스턴스가 있다면 현재 오브젝트를 파괴
            Destroy(gameObject);
        }
        else
        {
            // 인스턴스가 없다면 현재 오브젝트를 싱글톤으로 설정하고 DontDestroyOnLoad로 유지
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start()
    {
        // 배경음악 재생
        bgm.Play();
    }
}

