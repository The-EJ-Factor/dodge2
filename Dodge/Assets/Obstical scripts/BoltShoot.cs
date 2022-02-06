using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BoltShoot : MonoBehaviour
{
    public DateTime start;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        start = DateTime.Now;
        var X = (float)Math.Cos((transform.rotation.z * (Math.PI / 180)));
        var radiance = (Math.PI / 180) * -43;
        var Y = (float)Math.Sin((transform.rotation.z * (Math.PI / 180)));
        Debug.Log(transform.rotation.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.parent==null)
        {
            if ((DateTime.Now - start).TotalSeconds > 5/(speed/5))
            {
                Destroy(gameObject);
            }
            else
            {
                var X = (float)Math.Cos((transform.eulerAngles.z*(Math.PI/180)));
                var Y = (float)Math.Sin((transform.eulerAngles.z*(Math.PI/180)));
                transform.position += new Vector3(X * 0.05f*speed, Y * 0.05f*speed, 0f);
            }
        }
        
    }
}
