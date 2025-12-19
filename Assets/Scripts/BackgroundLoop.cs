using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
    public float scrollSpeed = 2f;
    private float width;
    void Start()
    {
        width = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        transform.Translate(Vector2.left * scrollSpeed * Time.deltaTime);
        if (transform.position.x < -width)
        {
            Reposition();
        }
    }

    void Reposition()
    {
        transform.Translate(Vector2.right * width * 2);
    }

}
