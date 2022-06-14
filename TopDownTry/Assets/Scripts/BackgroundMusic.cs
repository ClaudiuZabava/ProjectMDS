using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic backgroundMusic;
    private static AudioSource Changer;
    void Awake()
    {
        if(backgroundMusic == null)
        {

            backgroundMusic = this;
            //DontDestroyOnLoad(backgroundMusic);
            

        }
        else
        {
            Destroy(gameObject);
        }

    }
    void Update()
    {
        if(PlayerPrefs.GetInt("soundStats") == 1)
            {
                Changer = backgroundMusic.GetComponent(typeof(AudioSource)) as AudioSource;
                Changer.mute = false;
            }
        if(PlayerPrefs.GetInt("soundStats") == 2)
            {
                Changer = backgroundMusic.GetComponent(typeof(AudioSource)) as AudioSource;
                Changer.mute = true;
            }
        
    }
}
