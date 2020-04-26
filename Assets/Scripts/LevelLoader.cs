using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    int currentSceneIndex;
    [SerializeField] float timeToWait;

    void Start()
    {

        currentSceneIndex = SceneManager.GetActiveScene().buildIndex; 

        if ( currentSceneIndex == 0)
        {
            loadStartScene();
        }
    }

    private void SetSingleton()
    {
        if(FindObjectsOfType<LevelLoader>().Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void loadStartScene()
    {
        StartCoroutine(WaitAndLoadNextScene());
    }

    IEnumerator WaitAndLoadNextScene()
    {

        yield return new WaitForSeconds(timeToWait);

        LoadNextScene();
        

    }

    public void RestartScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadMainMenuScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Start Screen");
    }

    public void LoadNextScene()
    {
        currentSceneIndex++;
        SceneManager.LoadScene(currentSceneIndex);
    }
    public void LoadLoseScreen()
    {
        SceneManager.LoadScene("Game Over");
    }
}



























