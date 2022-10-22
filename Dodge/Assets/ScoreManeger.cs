using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManeger : MonoBehaviour
{
    public float score;
    public float timesurvived;
    //so what we need to do here is to make the score a label
    public Text scorelabel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timesurvived += Time.deltaTime;
        score = Mathf.Floor(timesurvived * ((timesurvived * 2) / 240) * 10);
        if (score >= 1000){
            AchivmentManager.giveachivment("starting off well");
        }
        scorelabel.text = score.ToString();
    }
}
