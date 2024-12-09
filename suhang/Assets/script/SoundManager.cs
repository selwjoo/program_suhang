using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{
    public AudioSource bgm;

    public AudioClip MainBGM;
    public AudioClip M3BGM;
    public AudioClip storyBGM;
    public AudioClip tutorialBGM;
    public AudioClip endingBGM;

    private static SoundManager instance; 

    private void Awake()
    {


        Scene scene = SceneManager.GetActiveScene();
        // 이미 인스턴스가 존재하는지 체크

        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        SceneManager.sceneLoaded += OnSceneLoaded;

        
      

    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Story")
        {
            bgm.clip = storyBGM;
            bgm.Play();
        }
        else if (scene.name == "Tutorial")
        {
            bgm.clip = tutorialBGM;
            bgm.Play();
        }
        else if (scene.name == "3")
        {
            bgm.clip = M3BGM;
            bgm.Play();
        }
        else if (scene.name == "Ending")
        {
            bgm.clip = endingBGM;
            bgm.Play();
        }
        else if (scene.name == "Main")
        {
            bgm.clip = MainBGM;
            bgm.Play();

        }

        
    }

    void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }


}

