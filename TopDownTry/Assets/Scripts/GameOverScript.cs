using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverScript : MonoBehaviour
{
    [SerializeField]
    private TMP_Text scoreText;

    void Start()
    {
        scoreText.text = "Your HighScore\n" + PlayerPrefs.GetFloat("highScore");
    }

    public void GoMainMenu() {
        SceneManager.LoadScene(0);
    }
    public  void ExitGame()
    {
        Application.Quit();
    }
}
