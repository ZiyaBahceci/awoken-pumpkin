using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
        AudioSource audioSource;
       public static AudioPlayer instance;
    // Start is called before the first frame update
    private void Awake() {
         if(instance == null){
         instance = this;
        }else{
            Destroy(gameObject);
        }
    }
    void Start()
    {
       
        DontDestroyOnLoad(this);
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = PlayerPrefsControler.GetVolume();
    }

    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
    }
}
