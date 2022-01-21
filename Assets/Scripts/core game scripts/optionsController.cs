using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class optionsController : MonoBehaviour
{
    [SerializeField] Slider volumeSlide;
    [SerializeField] Slider difficultySlide;
    [SerializeField] float defaultVolume = 0.8f;
    [SerializeField] float DefaultDifficulty = 0f;
   
    // Start is called before the first frame update
    AudioPlayer AudioPlayer;
    void Start()
    {
        volumeSlide.value = PlayerPrefsControler.GetVolume();
        difficultySlide.value = PlayerPrefsControler.GetDifficulty();
        AudioPlayer = FindObjectOfType<AudioPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (AudioPlayer){
            AudioPlayer.SetVolume(volumeSlide.value);
           
        }
        else
        {
            Debug.LogWarning("no music Player attached");
        }
        
    }
    public void SaveAndExit()
    {
        PlayerPrefsControler.SetMasterVolume(volumeSlide.value);
        PlayerPrefsControler.SetDifficulty(difficultySlide.value);
        FindObjectOfType<LevelLoader>().LoadMainMenu();

    }
    public void SetDefault()
    {
        difficultySlide.value = DefaultDifficulty;
        volumeSlide.value = defaultVolume;
      
    }
}
