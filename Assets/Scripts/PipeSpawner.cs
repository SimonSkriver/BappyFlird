using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject prefab;
    public float spawnRate = 2f;
    private float timer = 0f;

    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0f;
        }
    }

    void Start()
    {
        SpawnPipe();
    }

    void SpawnPipe()
    {
        Instantiate(prefab, new Vector2(4, Random.Range(2f, 8.5f)), transform.rotation);
    }
}
