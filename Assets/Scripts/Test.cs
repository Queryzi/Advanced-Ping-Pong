using JetBrains.Annotations;
using UnityEngine;

public class Test : MonoBehaviour
{


    public Rigidbody2D rb;

    public Transform startLoc;

    public float minAngle;

    public float maxAngle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(10,0);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetBall()
    {
        transform.position = startLoc.position;



            float angle = Random.Range(minAngle, maxAngle);

            Vector2 direction = Quaternion.Euler(0, 0, angle) * rb.linearVelocity.normalized;

            float speed = rb.linearVelocity.magnitude;

            rb.linearVelocity = direction * speed;

        //float randYVel
        //rb.linearVelocity
    }
}
