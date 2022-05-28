using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpinGunStart : MonoBehaviour
{
    public DateTime lastspawn;
    public DateTime lastchange;
    public DateTime lastbulletspawn;
    public GameObject SpingunShot;
    public float DI;
    public int CONT;


    // Start is called before the first frame update
    void Start()
    {
        lastchange = DateTime.Now;
        DI = UnityEngine.Random.Range(-1.5f,1.5f);
        CONT = UnityEngine.Random.Range(200,2000);
        lastspawn = DateTime.Now;
        lastbulletspawn = DateTime.Now;
        SpingunShot = transform.GetChild(2).gameObject;
}

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.eulerAngles += new Vector3(0,0,DI*1.2f);
        if ((DateTime.Now - lastchange).TotalMilliseconds > CONT)
        {
            DI = UnityEngine.Random.Range(-1.5f, 1.5f);
            CONT = UnityEngine.Random.Range(200, 2000);
            lastchange = DateTime.Now;
        }
        if ((DateTime.Now - lastbulletspawn).TotalMilliseconds > 500)
        {
            Instantiate(SpingunShot, SpingunShot.transform.position, SpingunShot.transform.rotation*Quaternion.Euler(0,0,DI*10));
            lastbulletspawn = DateTime.Now;
        }
        if ((DateTime.Now-lastspawn).TotalSeconds>5)
            {
            Destroy(gameObject);
        }
    }
}
