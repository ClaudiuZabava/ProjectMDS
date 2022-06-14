using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Meniu1 : MonoBehaviour
{
    [SerializeField]
    private TMP_Text hsc;
    void Start()
    {
        if(!PlayerPrefs.HasKey("soundStats"))
        {
            PlayerPrefs.SetInt("soundStats", 1);
            PlayerPrefs.Save();
        }
        if(!PlayerPrefs.HasKey("sfxStats"))
        {
            PlayerPrefs.SetInt("sfxStats", 1);
            PlayerPrefs.Save();
        }
        hsc.text = "Your Best Score\n" + PlayerPrefs.GetFloat("highScore");
    }

    public void PlayGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void OptionsMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void QuitGame() {
        //Debug.Log("QUIT!");
        Application.Quit();
    }
}
