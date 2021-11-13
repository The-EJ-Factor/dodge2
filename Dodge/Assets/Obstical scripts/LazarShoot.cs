using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LazarShoot : MonoBehaviour
{
    public GameObject LazarBolt;
    public DateTime lastspawn;
    // Start is called before the first frame update
    void Start()
    {
        LazarBolt = transform.GetChild(2).gameObject;
        lastspawn = DateTime.Now;
    }

    // Update is called once per frame
    void Update()
    {
        if ((DateTime.Now - lastspawn).TotalSeconds < 2)
        {
            Instantiate(LazarBolt, LazarBolt.transform.position, LazarBolt.transform.rotation);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
