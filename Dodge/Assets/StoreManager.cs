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
    public GameObject Content; 
    public GameObject ButtonP;
    public GameObject StoreItemPrefab;
    // Start is called before the first frame update
    void Start()
    {
        if (AllItems.Count==0)
        {
            AllItems.Add(new StoreItem(){name="Blank",description="Default",cash=0,gotten=false, Icon=Icons[0],visible=true});
            AllItems.Add(new StoreItem(){name="Sad",description="Sometimes it just doesn't your way",cash=10,gotten=false, Icon=Icons[1],visible=true});





        showbuttons();
        }
    }
    void buy(string name)
    {
    var buyitem = AllItems.Find(I=>I.name==name);
    if(MoneyManeger.tokens >= buyitem.cash){
       MoneyManeger.tokens -= buyitem.cash;
       buyitem.gotten=true;
       showbuttons();
    }
    
    }
    void showbuttons(){
        int children = Content.transform.childCount;
        for(int I = 0;I<children;I++){
            Destroy(Content.transform.GetChild(0));
        }
        foreach(var I in AllItems){
            var somthingelse = I.name;
            Button newbutton = new Button();
            newbutton.clicked=()=>{
                buy(somthingelse);
            };
            newbutton.text = I.name;
            Instantiate(newbutton,Content.transform);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
