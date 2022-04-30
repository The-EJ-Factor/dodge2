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
    public Camera main;
    public float ShakeDuration;
    // Start is called before the first frame update
    void Start()
    {
        lastdamage = DateTime.Now;

        
    }

    // Update is called once per frame
    void Update()
    {
        float x = UnityEngine.Random.Range(-0.01f,0.01f);
        float y = UnityEngine.Random.Range(-0.01f,0.01f);
        main.transform.position += new Vector3(x, y, 0f);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if((DateTime.Now - lastdamage).TotalSeconds>3)
        {
            Health -= 1;
            lastdamage = DateTime.Now;
            Label.text = (Health.ToString());
            ShakeDuration = 1.0f;

            
        }
    }
}
