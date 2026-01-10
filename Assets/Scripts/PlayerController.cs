using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header ("Movement settings")]
    [SerializeField] float jumpForce = 5f;

    [Header ("Components")]
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Animator anim;

    [Header ("Alive status")]
    public bool isAlive = true;


    void Start()
    {
        isAlive = true;
    }

    void Update()
    {
        CheckFalling();
    }

    public void OnJump()
    {
        if (isAlive)
        {
            rb.linearVelocity = Vector2.up * jumpForce;
            anim.SetTrigger("Jump");
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        isAlive = false;
    }

    void CheckFalling()
    {
        if (rb.linearVelocityY > 0)
        {
            anim.SetBool("isFalling", false);
        }
        else if (rb.linearVelocityY <= 0)
        {
            anim.SetBool("isFalling", true); 
        }
    }
}