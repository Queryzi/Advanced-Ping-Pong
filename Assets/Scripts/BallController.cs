
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
}
