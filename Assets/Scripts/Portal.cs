using UnityEditor.Experimental.GraphView;
using UnityEngine;



public class Portal : MonoBehaviour
{

    public GameObject twinPortal;
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
        col.transform.position = new Vector2(twinPortal.transform.position.x, twinPortal.transform.position.y);
    }
}
