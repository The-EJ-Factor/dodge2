using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class achivment{
    public string name;
    public string description;
    public float cash;
    public string skinname;
    public bool gotten;
}
public class AchivmentManager : MonoBehaviour
{
    public static AchivmentManager instance;
    public float showtime;
    public GameObject box;
    public Text title;
    public Text description;
    public static List <achivment> allachivments=new List <achivment>();
    public RectTransform ObjectScrollHight ;
    

    // Start is called before the first frame update
    void Start()
    {
        showtime = -4;
        instance=this;
        if (allachivments.Count==0)
        //AchivmentManager.giveachivment("default");
        {
            allachivments.Add(new achivment(){name="welcome",description="play the game for the first time",cash=0,skinname="happy",gotten=false});
            giveachivment("welcome");
            allachivments.Add(new achivment(){name="starting off well",description="Gain 1000 points in any difficulty",cash=0,gotten=false});
            allachivments.Add(new achivment(){name="it happens ¯\\_(ツ)_/¯",description="die for your first time",cash=100,gotten=false});
            allachivments.Add(new achivment(){name="balnk",description="default",cash=0,gotten=false});
            allachivments.Add(new achivment(){name="balnk",description="default",cash=0,gotten=false});
            allachivments.Add(new achivment(){name="balnk",description="default",cash=0,gotten=false});
            allachivments.Add(new achivment(){name="balnk",description="default",cash=0,gotten=false});
            allachivments.Add(new achivment(){name="balnk",description="default",cash=0,gotten=false});
            allachivments.Add(new achivment(){name="balnk",description="default",cash=0,gotten=false});
            allachivments.Add(new achivment(){name="balnk",description="default",cash=0,gotten=false});
            allachivments.Add(new achivment(){name="balnk",description="default",cash=0,gotten=false});
            allachivments.Add(new achivment(){name="balnk",description="default",cash=0,gotten=false});
            allachivments.Add(new achivment(){name="balnk",description="default",cash=0,gotten=false});
            allachivments.Add(new achivment(){name="balnk",description="default",cash=0,gotten=false});
            allachivments.Add(new achivment(){name="balnk",description="default",cash=0,gotten=false});
            allachivments.Add(new achivment(){name="balnk",description="default",cash=0,gotten=false});
            allachivments.Add(new achivment(){name="balnk",description="default",cash=0,gotten=false});
            allachivments.Add(new achivment(){name="balnk",description="default",cash=0,gotten=false});
            ObjectScrollHight.sizeDelta=new Vector2(0,allachivments.Count*130);
            
        }
    
    }
    public static void giveachivment(string name){
        var achivment = allachivments.Find(a=>(a.name==name));
        if(achivment!=null){
            if(achivment.gotten==false){
            achivment.gotten=true;
            instance.showtime=4f;
            instance.title.text=achivment.name;
            instance.description.text=achivment.description;
            MoneyManeger.tokens += (int)achivment.cash;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        showtime-=Time.deltaTime;
        if(showtime>0){
            box.transform.localPosition = new Vector2((showtime*showtime)*100, 248.23f);
            box.SetActive(true);
        }else{
                    if(showtime>-4){
            box.transform.localPosition = new Vector2((showtime*showtime)*-100, 248.23f);
            box.SetActive(true);
                    }
                    else{
            box.SetActive(false);
                    }
        }
    }
}