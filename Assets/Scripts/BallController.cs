using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody2D rb;

    public float ballSpeed = 7;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.linearVelocity = new Vector2(1, 0.5f).normalized * ballSpeed;
    }

    void Update()
    {
    }

    public void ResetBall()
    {
        rb.linearVelocity = Vector2.zero;
        transform.position = Vector2.zero;

        rb.linearVelocity = new Vector2(1, 0.5f).normalized * ballSpeed;
    }
}
