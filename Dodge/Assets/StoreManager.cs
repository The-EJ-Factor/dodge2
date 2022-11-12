using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreItem {
    public string name;
    public string description;
    public int cash;
    public Sprite Icon;
    public bool visible;
    public bool gotten;
}
public class StoreManager : MonoBehaviour
{
    public static List<StoreItem> AllItems=new List<StoreItem> ();
    public List <Sprite> Icons=new List<Sprite>();
    // Start is called before the first frame update
    void Start()
    {
        if (AllItems.Count==0)
        {
            AllItems.Add(new StoreItem(){name="Blank",description="Default",cash=0,gotten=false, Icon=Icons[0],visible=true});
            AllItems.Add(new StoreItem(){name="Sad",description="Sometimes it just doesn't your way",cash=10,gotten=false, Icon=Icons[1],visible=true});






        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
