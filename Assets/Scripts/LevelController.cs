using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{

    [SerializeField] int aliveAttackers;
    bool gameTimerFinished = false;
    [SerializeField] GameObject winLabel;
    [SerializeField] GameObject loseCanvas;

    AudioSource audioSource;
    void Start()
    {
        aliveAttackers = 0;
        winLabel.SetActive(false);
        loseCanvas.SetActive(false);
        audioSource = GetComponent<AudioSource>();
    }


    private void StopSpawners()
    {
        AttackerSpawner[] attackerSpawners = FindObjectsOfType<AttackerSpawner>();
        foreach (AttackerSpawner spawner in attackerSpawners)
        {
            spawner.SetSpawn(false); 
        }
        
    }

    public void AttackerCreated()
    {
        aliveAttackers++;
    }
    public void AttackerKilled()
    {
        aliveAttackers--;

        if (gameTimerFinished && aliveAttackers <= 0)
        {
            StartCoroutine(HandleWinCondition()); 
        }

    }
    public void setGameTimerFinished()
    {
        gameTimerFinished = true;
        StopSpawners();
    }
    IEnumerator HandleWinCondition()
    {
        yield return new WaitForSeconds(2f);
        winLabel.SetActive(true);
        audioSource.Play();
        yield return new WaitForSeconds(2f);
        GetComponent<LevelLoader>().LoadNextScene();
    }
    public void HandleLoseCondition()
    {
        loseCanvas.SetActive(true);
        Time.timeScale = 0f;
    }
}

























