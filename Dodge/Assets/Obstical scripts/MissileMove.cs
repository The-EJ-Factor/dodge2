using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MissileMove : MonoBehaviour
{
    public GameObject player;
    public float volocity;
    public DateTime animatime;
    public int phase;
    // Start is called before the first frame update
    void Start()
    {
        animatime = DateTime.Now;
        player = GameObject.Find("Player"); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (phase == 0)
        {
            var lookat = player.transform.position;
            var diffx = lookat.x - transform.position.x;
            var diffy = lookat.y - transform.position.y;
            var tp = Math.Atan(diffy / diffx) * 180 / Math.PI;
            if (lookat.x < transform.position.x) {
                tp += 180;
            }
            transform.eulerAngles = new Vector3(0f, 0f, (float)tp);
            transform.position += transform.right* 0.28f;
            if ((DateTime.Now - animatime).TotalSeconds > 4)
            {
                phase = 1;
                animatime = DateTime.Now;
            }
        }
        else if(phase == 1)
        {
            transform.position -= transform.right * 0.24f;
            if ((DateTime.Now - animatime).TotalSeconds > 0.3f)
            {
                phase = 2;
                animatime = DateTime.Now;
            }
        }
        else if(phase == 2)
        {
            transform.position += transform.right * 1.6f;
            if ((DateTime.Now - animatime).TotalSeconds > 5)
            {
                Destroy(gameObject);
            }
        }
    }
    void OnTriggerEnter2D(Collider2D C) {
        if (C.tag == "Player")
        {
            Destroy(gameObject);
        }
    
    }
}
