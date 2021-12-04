using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class health : MonoBehaviour
{
    public int Health = 3;
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
}
