using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5;
    public bool isPlayerOne;
    public bool debugMode = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = 0;
        float y = 0;
        if (isPlayerOne)
        {
            if (Input.GetKey(KeyCode.W)) y++;
            if (Input.GetKey(KeyCode.S)) y--;
            if (debugMode && Input.GetKey(KeyCode.A)) x--;
            if (debugMode &&Input.GetKey(KeyCode.D)) x++;
        }
        else
        {
            if (Input.GetKey(KeyCode.UpArrow)) y++;
            if (Input.GetKey(KeyCode.DownArrow)) y--;
            if (debugMode && Input.GetKey(KeyCode.LeftArrow)) x--;
            if (debugMode && Input.GetKey(KeyCode.RightArrow)) x++;
        }
        transform.Translate(new Vector3(x, y, 0) * moveSpeed * Time.deltaTime);
    }
}
