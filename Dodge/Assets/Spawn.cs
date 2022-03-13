using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Spawn : MonoBehaviour
{
    public GameObject Lazar;
    public GameObject Radiator;
    public GameObject Spingun;
    public GameObject PausePlayBlock;
    public GameObject Missile;
    public GameObject Bouncer;
    //public DateTime lastspawnL;
    //public DateTime lastspawnR;
    //public DateTime lastspawnS;
    //public DateTime lastspawnPP;
    public DateTime lastspawn;
    public System.Random Generator;
    public float spawnrate;
    // Start is called before the first frame update
    void Start()
    {
        /**lastspawnL = DateTime.Now;
        lastspawnR = DateTime.Now;
        lastspawnS = DateTime.Now;
        lastspawnPP = DateTime.Now;*/
        lastspawn = DateTime.Now;
        Generator = new System.Random();
    }

    // Update is called once per frame
    void Update()
    {
        if ((DateTime.Now - lastspawn).TotalSeconds > spawnrate)
        {
            int obstical = Generator.Next(1,7);
            if (obstical == 1)
            {
                lastspawn = DateTime.Now;
                float RandomX = Generator.Next(-10, 10);
                float RandomY = Generator.Next(-10, 10);
                float RandomR = Generator.Next(0, 360);
                Instantiate(Lazar, new Vector3(RandomX, RandomY, 0f),Quaternion.Euler(0f,0f,RandomR));
            }
            if (obstical == 2)
            {
                lastspawn = DateTime.Now;
                float RandomX = Generator.Next(-10, 10);
                float RandomY = Generator.Next(-10, 10);
                float RandomR = Generator.Next(0, 360);
                Instantiate(Radiator, new Vector3(RandomX, RandomY, 0f), Quaternion.Euler(0f, 0f, RandomR));
            }
            if (obstical == 3)
            {
                lastspawn = DateTime.Now;
                float RandomX = Generator.Next(-10, 10);
                float RandomY = Generator.Next(-10, 10);
                float RandomR = Generator.Next(0, 360);
                Instantiate(Spingun, new Vector3(RandomX, RandomY, 0f), Quaternion.Euler(0f, 0f, RandomR));
            }
            if (obstical == 4)
            {
                lastspawn = DateTime.Now;
                for (int i = Generator.Next(4, 8); i > 0; i -= 1)
                {
                    float RandomX = 0;
                    float RandomY = 0;
                    int RandomR = Generator.Next(0, 4) * 90;
                    switch (RandomR)
                    {
                        case 0:
                            RandomX = -32;
                            RandomY = Generator.Next(-15, 15);
                            break;
                        case 90:
                            RandomY = -18;
                            RandomX = Generator.Next(-30, 30);
                            break;
                        case 180:
                            RandomX = 32;
                            RandomY = Generator.Next(-15, 15);
                            break;
                        case 270:
                            RandomY = 18;
                            RandomX = Generator.Next(-30, 30);
                            break;

                    }
                    Instantiate(PausePlayBlock, new Vector3(RandomX, RandomY, 0f), Quaternion.Euler(0f, 0f, RandomR));
                }
            }
            if (obstical == 5)
            {
                lastspawn = DateTime.Now;
                float RandomX = Generator.Next(-10, 10);
                float RandomY = Generator.Next(-10, 10);
                float RandomR = Generator.Next(0, 360);
                Instantiate(Missile, new Vector3(RandomX, RandomY, 0f), Quaternion.Euler(0f, 0f, RandomR));
            }
            if (obstical == 6)
            {
                lastspawn = DateTime.Now;
                float RandomX = Generator.Next(-10, 10);
                float RandomY = Generator.Next(-10, 10);
                float RandomR = Generator.Next(0, 360);
                Instantiate(Bouncer, new Vector3(RandomX, RandomY, 0f), Quaternion.Euler(0f, 0f, RandomR));
            }
        }

    }
}
