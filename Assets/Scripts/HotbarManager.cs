using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class HotBarItem
{

    
    public string name;

    public Sprite sprite;

    public GameObject gameObject;

}
public class HotbarManager : MonoBehaviour
{



    

    //public HotBarItem[] hotBarItems = new HotBarItem[3];

    public List<HotBarItem> itemTemplates = new List<HotBarItem>();

    public List<HotBarItem> hotBarItems = new List<HotBarItem>();

    public Image[] hotBarImages = new Image[3];

    public Sprite emptySlot;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void UpdateHotbar()
    {
        for (int i = 0; i < hotBarImages.Length; i++)
        {
            
                hotBarImages[i].sprite = emptySlot;

            
            

        }
        for (int i = 0; i < hotBarItems.Count; i++)
        {
            
                hotBarImages[i].sprite = hotBarItems[i].sprite;

            
            

        }
    }

    public void AddRandomItem()
    {
        if(hotBarItems.Count<hotBarImages.Length)
        {
        int rand = Random.Range(0,itemTemplates.Count);

        hotBarItems.Add(itemTemplates[rand]);
        UpdateHotbar();
        }
    }
}
