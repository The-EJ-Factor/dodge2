using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Spawn : MonoBehaviour
{
    public GameObject Lazar;
    public GameObject Radiator;
    public GameObject Spingun;
    public DateTime lastspawnL;
    public DateTime lastspawnR;
    public DateTime lastspawnS;
    public System.Random Generator;
    public float spawnrate;
    // Start is called before the first frame update
    void Start()
    {
        lastspawnL = DateTime.Now;
        lastspawnR = DateTime.Now;
        lastspawnS = DateTime.Now;
        Generator = new System.Random();
        spawnrate = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if ((DateTime.Now - lastspawnL).TotalSeconds > spawnrate)
        {
            lastspawnL = DateTime.Now;
            float RandomX = Generator.Next(-10, 10);
            float RandomY = Generator.Next(-10, 10);
            float RandomR = Generator.Next(0, 360);
            Instantiate(Lazar, new Vector3(RandomX, RandomY, 0f),Quaternion.Euler(0f,0f,RandomR));
        }
        if ((DateTime.Now - lastspawnR).TotalSeconds > spawnrate)
        {
            lastspawnR = DateTime.Now;
            float RandomX = Generator.Next(-10, 10);
            float RandomY = Generator.Next(-10, 10);
            float RandomR = Generator.Next(0, 360);
            Instantiate(Radiator, new Vector3(RandomX, RandomY, 0f), Quaternion.Euler(0f, 0f, RandomR));
        }
        if ((DateTime.Now - lastspawnS).TotalSeconds > spawnrate)
        {
            lastspawnS = DateTime.Now;
            float RandomX = Generator.Next(-10, 10);
            float RandomY = Generator.Next(-10, 10);
            float RandomR = Generator.Next(0, 360);
            Instantiate(Spingun, new Vector3(RandomX, RandomY, 0f), Quaternion.Euler(0f, 0f, RandomR));
        }
    }
}
