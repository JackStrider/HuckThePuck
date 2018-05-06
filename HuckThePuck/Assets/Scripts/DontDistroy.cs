using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDistroy : MonoBehaviour 
{
    AudioSource audioSource;

    private void Awake()
    {

        audioSource = GetComponent<AudioSource>();

        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
        if (objs.Length > 1)
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);
    }

    private void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        int buildIndex = currentScene.buildIndex;

        switch (buildIndex)
        {
            case 0:
                audioSource.volume = 0.4f;
                break;
            case 1:
                audioSource.volume = 0.4f;
                break;
            case 2:
                audioSource.volume = 0.1f;
                break;
            case 3:
                audioSource.volume = 0.4f;
                break;
            case 4:
                audioSource.volume = 0.1f;
                break;
            case 5:
                audioSource.volume = 0.4f;
                break;
            case 6:
                audioSource.volume = 0.1f;
                break;
            case 7:
                audioSource.volume = 0.4f;
                break;
        }
    }
}
