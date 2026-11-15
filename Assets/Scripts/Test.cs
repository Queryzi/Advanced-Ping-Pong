using UnityEngine;

public class Test : MonoBehaviour
{


    public Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(10,7);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
