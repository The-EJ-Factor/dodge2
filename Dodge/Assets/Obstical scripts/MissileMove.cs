using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MissileMove : MonoBehaviour
{
    public GameObject player;
    public float volocity;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player"); 
    }

    // Update is called once per frame
    void Update()
    {
        var lookat = player.transform.position;
        var diffx = lookat.x - transform.position.x;
        var diffy = lookat.y - transform.position.y;
        var tp = Math.Atan(diffy / diffx) * 180 / Math.PI;
        if (lookat.x < transform.position.x) {
            tp += 180;
        }
        transform.eulerAngles = new Vector3(0f, 0f, (float)tp);
        transform.position += transform.right* 0.085f;
    }
    void OnTriggerEnter2D(Collider2D C) {
        if (C.tag == "Player")
        {
            Destroy(gameObject);
        }
    
    }
}
