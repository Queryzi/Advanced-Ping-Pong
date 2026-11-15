using UnityEngine;

public class Whirlwind : MonoBehaviour
{
    public float minAngle = -90f;
    public float maxAngle = 90f;
    public float minSpeed = 4f;
    public float maxSpeed = 12f;

    void OnTriggerEnter2D(Collider2D other)
    {
        BallController ball = other.GetComponent<BallController>();

        if (ball != null)
        {
            Rigidbody2D rb = ball.GetComponent<Rigidbody2D>();

            float angle = Random.Range(minAngle, maxAngle);

            Vector2 direction = Quaternion.Euler(0, 0, angle) * rb.linearVelocity.normalized;

            float speed = rb.linearVelocity.magnitude;

            int effect = Random.Range(0, 5);

            if (effect == 0)
            {
                speed *= 1.25f;
            }
            else if (effect == 1)
            {
                speed *= 0.75f;
            }
            
            speed = Mathf.Clamp(speed, minSpeed, maxSpeed);

            rb.linearVelocity = direction * speed;
        }
    }
}