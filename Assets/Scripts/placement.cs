using System;

using UnityEngine;


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

    public Keybinds keys;

    public float xUpperBound;

    public float xLowerBound;

    public float yUpperBound;

    public float yLowerBound;

    
    //public Color color;


    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if(Input.GetKeyDown(keys.useItem) && inHold == false)
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

            if(transform.position.y>yUpperBound)
            {
                transform.position = new Vector2(transform.position.x, yUpperBound);
            }
            if(transform.position.y<yLowerBound)
            {
                transform.position = new Vector2(transform.position.x, yLowerBound);
            }
            if(transform.position.x>xUpperBound)
            {
                transform.position = new Vector2(xLowerBound, transform.position.y);
            }
            if(transform.position.x<xLowerBound)
            {
                transform.position = new Vector2(xUpperBound, transform.position.y);
            }
            float hori;
            float vert;
                Debug.Log("is in hold");
                if(keys.name == "Player 2")
            {
                hori = Input.GetAxis("Player2Horizontal");
                vert = Input.GetAxis("Player2Vertical");
            }

            else
            {
                hori = Input.GetAxis("Horizontal");
                vert = Input.GetAxis("Vertical");
            }
                Debug.Log(hori);
                activeObject.transform.position += new Vector3(hori*speed* Time.deltaTime,vert*speed*Time.deltaTime);
                if(activeOption ==0)
            {
                activeObject2.transform.position += new Vector3(hori*speed* Time.deltaTime,-vert*speed*Time.deltaTime);
            }
            if(activeOption==1)
            {
                if(Input.GetKeyDown(keys.rotateItem))
                {
                    activeObject.transform.Rotate(0,0,90);
                }
            }
            if(Input.GetKeyDown(keys.useItem))
            {
                inHold = false;
                activeBC.enabled = true;
                activeSR.color = basicColor;
                
                if(activeOption == 0)
            {
               activeBC2.enabled = true;
                activeSR2.color = basicColor;
            }
                

            }

            Transform obPos = activeObject.transform;
            
            for (int i = 0; i < 2; i++)
            {
               if(obPos.position.y>yUpperBound)
            {
                obPos.position = new Vector2(obPos.position.x, yUpperBound);
            }
            if(obPos.position.y<yLowerBound)
            {
               obPos.position = new Vector2(obPos.position.x, yLowerBound);
            }
            if(obPos.position.x>xUpperBound)
            {
                obPos.position = new Vector2(xLowerBound, obPos.position.y);
            }
            if(obPos.position.x<xLowerBound)
            {
                obPos.position = new Vector2(xUpperBound, obPos.position.y);
            } 
            obPos = activeObject2.transform;
            }
            
        }
    }
}
