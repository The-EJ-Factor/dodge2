using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RadiatorStart : MonoBehaviour
{
    public DateTime lastspawn;
    public float RadInc;
    public bool[] existing = new bool[] { true, true, true };
    // Start is called before the first frame update
    void Start()
    {
        lastspawn = DateTime.Now;
    }

    // Update is called once per frame
    void Update()
    {
        if ((DateTime.Now - lastspawn).TotalSeconds > 5)
        {
            Destroy(gameObject);
        }
        if ((DateTime.Now - lastspawn).TotalSeconds > 1.5 && existing[0])
        {
            transform.GetChild(0).localScale += new Vector3(RadInc, RadInc, 0);
            var C = transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color;
            transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = new Color(C.r, C.g, C.b, C.a - 0.01f);
            if(C.a <= 0f)
            {
                Destroy(transform.GetChild(0).gameObject);
                existing[0] = false;
            }
        }
        if ((DateTime.Now - lastspawn).TotalSeconds > 2 && existing[1])
        {
            transform.GetChild(1).localScale += new Vector3(RadInc, RadInc, 0);
            var C = transform.GetChild(1).gameObject.GetComponent<SpriteRenderer>().color;
            transform.GetChild(1).gameObject.GetComponent<SpriteRenderer>().color = new Color(C.r, C.g, C.b, C.a - 0.01f);
            if (C.a <= 0f)
            {
                Destroy(transform.GetChild(1).gameObject);
                existing[1] = false;
            }
        }
        if ((DateTime.Now - lastspawn).TotalSeconds > 2.5 && existing[2])
        {
            transform.GetChild(2).localScale += new Vector3(RadInc, RadInc, 0);
            var C = transform.GetChild(2).gameObject.GetComponent<SpriteRenderer>().color;
            transform.GetChild(2).gameObject.GetComponent<SpriteRenderer>().color = new Color(C.r, C.g, C.b, C.a - 0.01f);
            if (C.a <= 0f)
            {
                Destroy(transform.GetChild(2).gameObject);
                existing[2] = false;
            }
        }
    }
}
