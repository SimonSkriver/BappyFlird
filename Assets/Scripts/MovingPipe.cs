using UnityEngine;

public class MovingPipe : MonoBehaviour
{
    [Header ("Movement settings")]
    [SerializeField] float moveSpeed = 3f;

    public Vector2[] moveDirection;
    private Vector2 initialMoveDirection;
    private float minHeight;
    private float maxHeight;

    void Start()
    {
        minHeight = transform.position.y - 1;
        maxHeight = transform.position.y + 1;
        initialMoveDirection = moveDirection[Random.Range(0, 2)];
    }

    void Update()
    {
        transform.Translate(initialMoveDirection * moveSpeed * Time.deltaTime);

        if (transform.position.y >= maxHeight)
        {
            initialMoveDirection = -initialMoveDirection;
        }

        if (transform.position.y <= minHeight)
        {
            initialMoveDirection = -initialMoveDirection;
        }
    }
}