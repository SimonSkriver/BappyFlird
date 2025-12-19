using UnityEngine;

public class ScoreTrigger : ScoreManager
{
    private ScoreManager scoreManager;

    void Start()
    {
        scoreManager = FindAnyObjectByType<ScoreManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            scoreManager.AddScore();
        }
    }
}
