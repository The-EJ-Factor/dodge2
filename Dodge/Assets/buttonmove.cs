using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonmove : MonoBehaviour

{
    public float totaltime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        totaltime += Time.deltaTime;
        float offset = Mathf.Sin(totaltime*4);
        transform.localPosition = new Vector3(0, offset*10, 0);
    }
}
