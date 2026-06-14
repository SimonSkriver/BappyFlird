using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [Header ("Pipe settings")]
    [SerializeField] GameObject stillPipe;
    [SerializeField] GameObject slowMovingPipe;
    [SerializeField] float spawnRate = 2f;

    [Header ("Score manager")]
    [SerializeField] ScoreManager scoreManager;

    private float timer = 0f;

    void Start()
    {
        SpawnPipe();
        scoreManager = FindAnyObjectByType<ScoreManager>();
    }

    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0f;
        }
    }

    void SpawnPipe()
    {
        if (scoreManager.score < 10)
        {
            Instantiate(stillPipe, new Vector2(4, Random.Range(2f, 8.5f)), transform.rotation);
        }
        else
        {
            float roll = Random.value;
            if (roll < 0.35f)
            {
                Instantiate(slowMovingPipe, new Vector2(4, Random.Range(2f, 8.5f)), transform.rotation);
            }
            else
            {
                Instantiate(stillPipe, new Vector2(4, Random.Range(2f, 8.5f)), transform.rotation);
            }
        }
    }
}
