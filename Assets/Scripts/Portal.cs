using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;



public class Portal : MonoBehaviour
{

    public GameObject twinPortal;

    public BoxCollider2D BC;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        BC = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        col.transform.position = new Vector2(twinPortal.transform.position.x, twinPortal.transform.position.y);
        col.GetComponent<BoxCollider2D>().enabled = false;
        StartCoroutine(General.DelayFunction( () => {col.GetComponent<BoxCollider2D>().enabled = true;}, 0.17f));

    }

    


    
}
