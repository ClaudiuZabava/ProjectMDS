using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Meniu2 : MonoBehaviour
{
    [SerializeField]
    private GameObject err;

    private TMP_Text scoreText;

    public void LoadMap1() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void LoadMap2() 
    {
        if(PlayerPrefs.GetFloat("highScore") >= 200)
        {
            err.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        }
        else
        {
            scoreText = err.GetComponent(typeof(TMP_Text)) as TMP_Text;
            scoreText.text = "You need 200 highscore to unlock this map!\n" + "Your HighScore: " + PlayerPrefs.GetFloat("highScore");
            err.SetActive(true);
        }
        
    }

    public void LoadMap3() {
        if(PlayerPrefs.GetFloat("highScore") >= 500)
        {
            err.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
        }
        else
        {
            scoreText = err.GetComponent(typeof(TMP_Text)) as TMP_Text;
            scoreText.text = "You need 500 highscore to unlock this map!\n" + "Your HighScore: " + PlayerPrefs.GetFloat("highScore");
            err.SetActive(true);
        }
    }
    public void Back() 
    {
        err.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
