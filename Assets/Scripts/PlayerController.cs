using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 5f;
    public Rigidbody2D rb;
    public bool isAlive = true;

    void Start()
    {
        isAlive = true;
    }

    public void OnJump()
    {
        if (isAlive)
        {
            rb.linearVelocity = Vector2.up * jumpForce;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        isAlive = false;
    }
}