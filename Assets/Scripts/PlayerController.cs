
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5;
    public bool isPlayerOne;
    public bool debugMode = false;

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float x = 0;
        float y = 0;

        if (isPlayerOne)
        {
            if (Input.GetKey(KeyCode.W)) y++;
            if (Input.GetKey(KeyCode.S)) y--;
            if (debugMode && Input.GetKey(KeyCode.A)) x--;
            if (debugMode && Input.GetKey(KeyCode.D)) x++;
        }
        else
        {
            if (Input.GetKey(KeyCode.UpArrow)) y++;
            if (Input.GetKey(KeyCode.DownArrow)) y--;
            if (debugMode && Input.GetKey(KeyCode.LeftArrow)) x--;
            if (debugMode && Input.GetKey(KeyCode.RightArrow)) x++;
        }

        movement = new Vector2(x, y).normalized;
    }

    void FixedUpdate()
    {
        rb.linearVelocity = movement * moveSpeed;
    }
}
