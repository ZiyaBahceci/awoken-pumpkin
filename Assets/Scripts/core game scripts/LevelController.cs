using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LevelController : MonoBehaviour
{
    [SerializeField] float waitToLoad = 3f;
    [SerializeField] GameObject winLabel;
    [SerializeField] GameObject LooseLabel;
    int numofAttackers;
    bool levelTimerFinished = false;
    private void Start()
    {
        winLabel.SetActive(false);
        LooseLabel.SetActive(false);
        numofAttackers=0;
    }
    public void AttackerSpawned()
    {
        numofAttackers+=1;
       
    }
    public void AttackerKilled()
    {
        numofAttackers--;
        
        if (numofAttackers <= 0 && levelTimerFinished)
        {
            StartCoroutine(HandleWinCondition());
            
        }
        //Debug.Log(numberOfAttackers);
    }

    IEnumerator HandleWinCondition()
    {
        winLabel.SetActive(true);
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(waitToLoad);
        FindObjectOfType<LevelLoader>().LoadNextScene();
    }

    public void LevelTimerFinished()
    {
        levelTimerFinished = true;
         StopSpawners();
    }

    private void StopSpawners()
    {
        AttackerSpawner[] spawnerArray = FindObjectsOfType<AttackerSpawner>();

        foreach (AttackerSpawner spawner in spawnerArray)
        {
            spawner.StopSpawning();
        }
    }
       public void HandleLooseCondition()
    {
        LooseLabel.SetActive(true);
        Time.timeScale = 0;
    }

    
}
