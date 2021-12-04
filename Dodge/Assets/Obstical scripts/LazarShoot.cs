using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LazarShoot : MonoBehaviour
{
    public GameObject LazarBolt;
    public DateTime lastspawn;
    public DateTime waitshoot;
    public float x;
    public float y;
    public float z;
    // Start is called before the first frame update
    void Start()
    {
        LazarBolt = transform.GetChild(2).gameObject;
        lastspawn = DateTime.Now;
        waitshoot = DateTime.Now;
        x = LazarBolt.transform.position.x;
        y = LazarBolt.transform.position.y;
        z = LazarBolt.transform.position.z;
    }
    public int spawntick;
    // Update is called once per frame
    void Update()
    {
        if ((DateTime.Now - lastspawn).TotalSeconds < 2 && (DateTime.Now - waitshoot).TotalSeconds > 1)
        {
            if (spawntick > 0)
            { Instantiate(LazarBolt, new Vector3(x,y,z), LazarBolt.transform.rotation);
                spawntick = 0;
            }
        }
        else if((DateTime.Now - lastspawn).TotalSeconds > 2)
        {
            Destroy(gameObject);
        }
        spawntick += 1;
    }
}
