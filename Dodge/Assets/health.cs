using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class health : MonoBehaviour
{
    public int Health = 3;
    public Text Label;
    public DateTime lastdamage;
    // Start is called before the first frame update
    void Start()
    {
        lastdamage = DateTime.Now;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if((DateTime.Now - lastdamage).TotalSeconds>3)
        {
            Health -= 1;
            lastdamage = DateTime.Now;
            Label.text = (Health.ToString());
        }
    }
}
