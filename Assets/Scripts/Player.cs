using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{


    public Rigidbody2D rb;

    public float speed;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float hori = Input.GetAxisRaw("Horizontal");
        

        
    }
}
