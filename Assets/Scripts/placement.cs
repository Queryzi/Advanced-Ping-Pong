using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class placement : MonoBehaviour
{

    public bool inHold = true;

    public float speed;
    public GameObject activeObject;

    public GameObject activeObject2;

    public GameObject[] options;

    public int activeOption;

    public SpriteRenderer activeSR;

    public BoxCollider2D activeBC;

     public SpriteRenderer activeSR2;

    public BoxCollider2D activeBC2;

    public Color inHoldColor;

    public Color basicColor;

    public Vector2 spawnLocation;


    public Vector2 portalSpawnLocation;

    
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
                
                
                activeObject = Instantiate(options[activeOption],spawnLocation,transform.rotation);
               
                
               activeObject.SetActive(true);
               activeObject.transform.position = spawnLocation;
               activeBC = activeObject.GetComponent<BoxCollider2D>();
               activeSR =  activeObject.GetComponent<SpriteRenderer>();

               activeBC.enabled = false;
               activeSR.color = inHoldColor;
               inHold = true;

                if(activeOption == 0)
                {
                activeObject2 = Instantiate(options[activeOption],spawnLocation,transform.rotation);

                activeObject.GetComponent<Portal>().twinPortal = activeObject2;
                activeObject2.GetComponent<Portal>().twinPortal = activeObject;


                activeObject2.SetActive(true);
                activeObject2.transform.position = spawnLocation;

               activeBC2 = activeObject2.GetComponent<BoxCollider2D>();
               activeSR2 =  activeObject2.GetComponent<SpriteRenderer>();

                activeBC2.enabled = false;
               activeSR2.color = inHoldColor;
                }   
            }
        else if(inHold)
        {
                Debug.Log("is in hold");
                float hori = Input.GetAxis("Horizontal");
                float vert = Input.GetAxis("Vertical");
                Debug.Log(hori);
                activeObject.transform.position += new Vector3(hori*speed* Time.deltaTime,vert*speed*Time.deltaTime);
                if(activeOption ==0)
            {
                activeObject2.transform.position += new Vector3(hori*speed* Time.deltaTime,-vert*speed*Time.deltaTime);
            }
            if(activeOption==1)
            {
                if(Input.GetKeyDown(KeyCode.G))
                {
                    activeObject.transform.Rotate(0,0,90);
                }
            }
            if(Input.GetKeyDown(KeyCode.F))
            {
                inHold = false;
                activeBC.enabled = true;
                activeSR.color = basicColor;
                
                if(activeOption ==0)
            {
               activeBC2.enabled = true;
                activeSR2.color = basicColor;
            }
                

            }
        }
    }
}
