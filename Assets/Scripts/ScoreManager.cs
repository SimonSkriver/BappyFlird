using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI highscoreText;
    [SerializeField] int score;
    private int highscore;

    void Start()
    {
        score = 0;
        highscore = PlayerPrefs.GetInt("highscore", 0);
        highscoreText.text = "Highscore: " + highscore;
        scoreText.text = "Score: " + score.ToString();
    }

    public void AddScore()
    {
        score++;
        scoreText.text = "Score: " + score.ToString();

        if(PlayerPrefs.GetInt("highscore") < score)
        {
            Debug.Log("New highscore");
            highscore = score;
            PlayerPrefs.SetInt("highscore", score);
            highscoreText.text = "Highscore: " + PlayerPrefs.GetInt("highscore");
        }
    }
}   
