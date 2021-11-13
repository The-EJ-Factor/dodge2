using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Spawn : MonoBehaviour
{
    public GameObject Lazar;
    public DateTime lastspawn;
    public System.Random Generator;
    // Start is called before the first frame update
    void Start()
    {
        lastspawn = DateTime.Now;
        Generator = new System.Random();
    }

    // Update is called once per frame
    void Update()
    {
        if ((DateTime.Now - lastspawn).TotalSeconds > 10)
        {
            lastspawn = DateTime.Now;
            float RandomX = Generator.Next(-10, 10);
            float RandomY = Generator.Next(-10, 10);
            float RandomR = Generator.Next(0, 360);
            Instantiate(Lazar, new Vector3(RandomX, RandomY, 0f),Quaternion.Euler(0f,0f,RandomR));
        }
    }
}
