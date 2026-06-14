using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    private ScoreManager scoreManager;

    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip scoreSFX;

    void Start()
    {
        scoreManager = FindAnyObjectByType<ScoreManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            scoreManager.AddScore();
            audioSource.PlayOneShot(scoreSFX);
        }
    }
}