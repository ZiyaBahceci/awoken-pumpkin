using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameOptions : MonoBehaviour
{
    public bool flag = false;
    [SerializeField] Slider volumeSlide;
    [SerializeField] Slider difficultySlide;
    [SerializeField] float defaultVolume = 0.8f;
    [SerializeField] float DefaultDifficulty = 0f;
    AudioPlayer AudioPlayer;
    // Start is called before the first frame update
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
        
        
       if(Input.GetKeyDown(KeyCode.Escape) && flag == false){
          transform.GetChild(0).gameObject.SetActive(true);
           Time.timeScale=0;
           flag = true;
          
           
       } 
       else if(Input.GetKeyDown(KeyCode.Escape) && flag == true){
       transform.GetChild(0).gameObject.SetActive(false);
        PlayerPrefsControler.SetMasterVolume(volumeSlide.value);
        PlayerPrefsControler.SetDifficulty(difficultySlide.value);
       
           Time.timeScale=1;
           flag = false;
       }
    }
    public void SetDefault()
    {
        difficultySlide.value = DefaultDifficulty;
        volumeSlide.value = defaultVolume;
      
    }
}
