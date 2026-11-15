using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class placement : MonoBehaviour
{

    public bool inHold = true;

    public float speed;
    public GameObject activeObject;

    public GameObject[] options;

    public SpriteRenderer activeSR;

    public BoxCollider2D activeBC;

    public Color inHoldColor;

    public Color basicColor;

    public Vector2 spawnLocation;

    //public Color color;


    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.F) && inHold == false)
            {
                
               activeObject.SetActive(true);
                activeObject.transform.position = spawnLocation;

               activeBC = activeObject.GetComponent<BoxCollider2D>();
               activeSR =  activeObject.GetComponent<SpriteRenderer>();

                activeBC.enabled = false;
               activeSR.color = inHoldColor;
               inHold = true;

            }
        if(inHold)
        {
                Debug.Log("is in hold");
                float hori = Input.GetAxisRaw("Horizontal");
                float vert = Input.GetAxisRaw("Vertical");
                activeObject.transform.position += new Vector3(hori*speed* Time.deltaTime,vert*speed*Time.deltaTime);
            if(Input.GetKeyDown(KeyCode.F))
            {
                inHold = false;
                activeBC.enabled = true;
                activeSR.color = basicColor;
                
                

            }
        }
    }
}
