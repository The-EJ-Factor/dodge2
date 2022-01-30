using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RadiatorStart : MonoBehaviour
{
    public DateTime lastspawn;
    public float RadInc;
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
        if ((DateTime.Now - lastspawn).TotalSeconds > 1.5)
        {
            transform.GetChild(0).localScale += new Vector3(RadInc, RadInc, 0);
            var C = transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color;
            transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = new Color(C.r, C.g, C.b, C.a - 0.01f);
        }
        if ((DateTime.Now - lastspawn).TotalSeconds > 2)
        {
            transform.GetChild(1).localScale += new Vector3(RadInc, RadInc, 0);
            var C = transform.GetChild(1).gameObject.GetComponent<SpriteRenderer>().color;
            transform.GetChild(1).gameObject.GetComponent<SpriteRenderer>().color = new Color(C.r, C.g, C.b, C.a - 0.01f);
        }
        if ((DateTime.Now - lastspawn).TotalSeconds > 2.5)
        {
            transform.GetChild(2).localScale += new Vector3(RadInc, RadInc, 0);
            var C = transform.GetChild(2).gameObject.GetComponent<SpriteRenderer>().color;
            transform.GetChild(2).gameObject.GetComponent<SpriteRenderer>().color = new Color(C.r, C.g, C.b, C.a - 0.01f);
        }
    }
}
