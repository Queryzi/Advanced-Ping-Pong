using UnityEngine;
using UnityEngine.Rendering;

public class Potion : MonoBehaviour
{


    public float duration;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.TryGetComponent(out BallController ball))
        {
            ball.GetComponent<SpriteRenderer>().enabled = false;
            StartCoroutine(General.DelayFunction(() => ball.GetComponent<SpriteRenderer>().enabled = true, duration));
        }
    }
}
