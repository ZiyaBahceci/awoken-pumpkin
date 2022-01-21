using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    int CurrentSceneIndex;
    [SerializeField] int timeToWait = 4;

    // Start is called before the first frame update
    void Start()
    {
        CurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(CurrentSceneIndex== 0)
         {
             StartCoroutine(WaitForTime());
         }
    }


     IEnumerator WaitForTime()
     {
         yield return new WaitForSeconds(timeToWait);
         LoadNextScene();
     }
    public void LoadNextScene()
    {if(CurrentSceneIndex <5){
        SceneManager.LoadScene(CurrentSceneIndex + 1);

    }else if(CurrentSceneIndex==5){
                SceneManager.LoadScene(CurrentSceneIndex + 1);

    }
    }
    public void RestartScene()
    {
        SceneManager.LoadScene(CurrentSceneIndex);
        Time.timeScale = 1;
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Start Screen");
        Time.timeScale = 1;
    }
    public void LoadYouLose()
    {
        SceneManager.LoadScene("Lose Screen");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void LoadOptions()
    {
        SceneManager.LoadScene("Option Screen");
    }
   
}
