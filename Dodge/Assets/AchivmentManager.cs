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
    

    // Start is called before the first frame update
    void Start()
    {
        instance=this;
        if (allachivments.Count==0)
        {
            allachivments.Add(new achivment(){name="welcome",description="play the game for the first time",cash=0,skinname="happy",gotten=false});
            giveachivment("welcome");
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
            allachivments.Add(new achivment(){name="balnk",description="default",cash=0,gotten=false});
            allachivments.Add(new achivment(){name="balnk",description="default",cash=0,gotten=false});
            
        }
    }
    public static void giveachivment(string name){
        var achivment = allachivments.Find(a=>(a.name==name));
        if(achivment!=null){
            achivment.gotten=true;
            instance.showtime=4f;
            instance.title.text=achivment.name;
            instance.description.text=achivment.description;
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
