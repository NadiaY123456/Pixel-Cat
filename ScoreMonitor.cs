using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreMonitor : MonoBehaviour
{
    // Start is called before the first frame update
    public static ScoreMonitor instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;

    int score = 0;
    int highscore = 0;

    private void Awake() {
        instance = this; 
    }
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = "Score: " + score.ToString();
        highscoreText.text = "High Score: " + highscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPoint() {
        score += 1;
        scoreText.text = "Score: " + score.ToString();
        if (highscore < score){
            PlayerPrefs.SetInt("highscore", score);
        }
        
    }
}
