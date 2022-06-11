using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrier : MonoBehaviour
{
    public float screenwidth;
    public float screenheight;
    public GameObject b;
    public static Vector3 bottomleft;
    public static Vector3 topright;
    // Start is called before the first frame update
    void Start()
    {
        b = GameObject.Find("barriero");
        screenwidth = Camera.main.orthographicSize * Screen.width / Screen.height;
        screenheight = Camera.main.orthographicSize;
        bottomleft = new Vector3(-screenwidth, -screenheight, 0f);
        topright = new Vector3(screenwidth, screenheight, 0f);
        Instantiate(b, new Vector3(screenwidth*-1-3,0f,0f),Quaternion.identity);
        Instantiate(b, new Vector3(screenwidth+3,0f,0f),Quaternion.identity);
        Instantiate(b, new Vector3(0f,screenheight+3,0f),Quaternion.Euler(0f,0f,90f));
        Instantiate(b, new Vector3(0f,screenheight*-1-3,0f),Quaternion.Euler(0f,0f,90f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
