
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody2D rb;

    public float ballSpeed = 7;

    public float minAngle;

    public float maxAngle;

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

        //rb.linearVelocity = new Vector2(1, 0.5f).normalized * ballSpeed;

         transform.position = Vector2.zero;



            int rand = Random.Range(1,3);
        Vector2 direction = Vector2.zero;

            if(rand ==1)
        {
            direction = Vector2.right;
        }
        else
        {
            direction = Vector2.left;
        }


            rb.linearVelocity = direction * ballSpeed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
            // Rigidbody2D paddleRB = collision.gameObject.GetComponent<Rigidbody2D>();

            // Vector2 direction = rb.linearVelocity.normalized;

            // float angle = 0;

            // if (paddleRB.linearVelocity.y > 0.01f)
            // {
            //     angle = Random.Range(5f, 15f);
            // }
            // else if (paddleRB.linearVelocity.y < -0.01f)
            // {
            //     angle = Random.Range(-15f, -5f);
            // }

            // direction = Quaternion.Euler(0, 0, angle) * direction;

            // rb.linearVelocity = direction * ballSpeed;
            Rigidbody2D paddleRB = collision.gameObject.GetComponent<Rigidbody2D>();

            float angle = paddleRB.linearVelocity.y * 3f;

            // Limit the maximum angle
            angle = Mathf.Clamp(angle, -30f, 30f);

            Vector2 direction = rb.linearVelocity.normalized;

            direction = Quaternion.Euler(0, 0, angle) * direction;

            rb.linearVelocity = direction * ballSpeed;
        }
    }
}
