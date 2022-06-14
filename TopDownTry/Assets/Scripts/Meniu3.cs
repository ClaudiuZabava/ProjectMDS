using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Meniu3 : MonoBehaviour
{
    public void MusicOn()
    {
        PlayerPrefs.SetInt("soundStats",1);
        PlayerPrefs.Save();
    }
    public void MusicOff()
    {
        PlayerPrefs.SetInt("soundStats",2);
        PlayerPrefs.Save();
    }

    public void SfxOn()
    {
        PlayerPrefs.SetInt("sfxStats",1);
        PlayerPrefs.Save();
    }
    public void SfxOff()
    {
        PlayerPrefs.SetInt("sfxStats",2);
        PlayerPrefs.Save();
    }

    public void Back() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
