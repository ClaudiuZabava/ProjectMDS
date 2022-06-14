using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{

    private int pause  = 0;

    [SerializeField]
    private GameObject panou;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("pause",pause);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(pause == 0)
            {
                PauseGame();
            }
                
            else
            {
                ResumeGame();
            }
                
        }

    }

    public void PauseGame()
    {
        pause = 1;
        PlayerPrefs.SetInt("pause",pause);
        Time.timeScale = 0f;
        this.panou.SetActive(true);
    }
    public void ResumeGame()
    {
        pause = 0;
        PlayerPrefs.SetInt("pause",pause);
        Time.timeScale = 1f;
        this.panou.SetActive(false);
    }

    public void GoBackMain()
    {
        pause = 0;
        PlayerPrefs.SetInt("pause",pause);
        Time.timeScale = 1f;
        this.panou.SetActive(false);
        SceneManager.LoadScene(0);
    }
}
