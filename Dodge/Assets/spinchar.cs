using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinchar : MonoBehaviour
{
    public Rigidbody2D MyBody;
    public float totaltime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        totaltime += Time.deltaTime;
        Debug.Log(Time.deltaTime);
        if ( MyBody.angularVelocity < 500)
        {
            MyBody.angularVelocity = MyBody.angularVelocity + 10f+Mathf.Sin(totaltime*2.5f)*10;
        }
    }
}
