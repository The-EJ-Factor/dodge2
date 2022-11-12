using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;


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
        Health=DifficultyManeger.current.health;
        Label.text = (Health.ToString());
    }

    // Update is called once per frame
    void FixedUpdate()
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
            if (Health<=0){
                AchivmentManager.giveachivment("it happens ¯\\_(ツ)_/¯");
                MoneyManeger.tokens += (int)Math.Floor(ScoreManeger.score/100);
                SceneManager.LoadScene("Title");
            }

            
        }
    }
}
