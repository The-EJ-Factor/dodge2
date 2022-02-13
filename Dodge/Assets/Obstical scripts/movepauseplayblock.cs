using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class movepauseplayblock : MonoBehaviour
{
    public Rigidbody2D Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player").GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Math.Abs(Player.velocity.x) + Math.Abs(Player.velocity.y) > 3)
        {
            transform.position += transform.right * (Math.Abs(Player.velocity.x) + Math.Abs(Player.velocity.y))/500;
            transform.GetChild(1).gameObject.SetActive(false);
            transform.GetChild(2).gameObject.SetActive(true);
        }
        else
        {
            transform.GetChild(1).gameObject.SetActive(true);
            transform.GetChild(2).gameObject.SetActive(false);
        }
    }
}
