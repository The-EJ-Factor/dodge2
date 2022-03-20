using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileMove : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player"); 
    }

    // Update is called once per frame
    void Update()
    {
        var lookat = player.transform.position;
        lookat.z = transform.position.z;
        transform.LookAt(lookat,Vector3.forward);
        transform.eulerAngles = new Vector3(0f, 0f, -transform.eulerAngles.z);
    }
}
