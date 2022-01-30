using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpinGunStart : MonoBehaviour
{
    public DateTime lastspawn;

    // Start is called before the first frame update
    void Start()
    {
        lastspawn = DateTime.Now;
    }

    // Update is called once per frame
    void Update()
    {
        if ((DateTime.Now-lastspawn).TotalSeconds>5)
            {
            Destroy(gameObject);
        }
    }
}
