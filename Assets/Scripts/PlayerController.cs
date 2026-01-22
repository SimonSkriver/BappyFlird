using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 5f;
    public Rigidbody2D rb;

    public void OnJump()
    {
        Debug.Log("Jump key pressed");
        rb.linearVelocity = Vector2.up * jumpForce;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        Debug.Log("Player collided with " + collision.gameObject);
    }
}