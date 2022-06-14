using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreForUI : MonoBehaviour
{
    public static ScoreForUI instance;
    [SerializeField]
    private TMP_Text scoreText;

    private float score=0;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        scoreText.text = "SCORE: " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "SCORE: "+ score.ToString() ;
    }
    public void AddPoints(float points)
    {
        score += points;
    }
}
