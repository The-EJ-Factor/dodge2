using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TurretStart : MonoBehaviour
{
    public DateTime lastspawn;
    public DateTime lastchange;
    public DateTime lastbulletspawn;
    public GameObject SpingunShot;
    public GameObject player;
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
        player = GameObject.Find("Player");
}

    // Update is called once per frame
    void FixedUpdate()
    {
            var lookat = player.transform.position;
            var diffx = lookat.x - transform.position.x;
            var diffy = lookat.y - transform.position.y;
            var tp = Math.Atan(diffy / diffx) * 180 / Math.PI;
            if (lookat.x < transform.position.x) {
                tp += 180;
            }
            transform.eulerAngles = new Vector3(0f, 0f, (float)tp);

        if ((DateTime.Now - lastbulletspawn).TotalMilliseconds > 3000)
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
