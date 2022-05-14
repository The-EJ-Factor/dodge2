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
        if (ShakeDuration > 0)
        {
        float x = UnityEngine.Random.Range(-0.5f,0.5f);
        float y = UnityEngine.Random.Range(-0.5f,0.5f);
        main.transform.position += new Vector3(x, y, 0f);
            ShakeDuration -= Time.deltaTime;
        }
        else
        {
            main.transform.position = new Vector3(0f, 0f, -10f);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if((DateTime.Now - lastdamage).TotalSeconds>3 && collision.gameObject.tag=="Damage")
        {
            Health -= 1;
            lastdamage = DateTime.Now;
            Label.text = (Health.ToString());
            ShakeDuration = 0.3f;

            
        }
    }
}
