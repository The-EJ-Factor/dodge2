using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class movement : MonoBehaviour
{
    public BoxCollider2D MyCollider;
    public float prevx;
    public float prevy;
    public float mv;
    public float rv;
    public float screenwidth;
    public float screenheight;
    // Start is called before the first frame update
    void Start()
    {
        PhysicsMaterial2D NewMaterial = new PhysicsMaterial2D();
        NewMaterial.bounciness = 0f;
        NewMaterial.friction = 0f;
        mv = 1;
        MyCollider.sharedMaterial = NewMaterial;
        screenwidth = Camera.main.orthographicSize*Screen.width/Screen.height;
        screenheight = Camera.main.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
       
        
        prevx = transform.position.x;
        prevy = transform.position.y;
        var adjusted = Math.Min(8, mv);
        var x = (Input.GetAxis("Horizontal")*adjusted);
        var y = (Input.GetAxis("Vertical")*adjusted);
        if (x != 0 || y != 0)
        {
            mv += .2f;
        }
        else if (mv > 1)
        {
            mv -= .2f;
        }
        transform.position += new Vector3((float)x * .05f, (float)y * .05f, 0);
        rv += (Math.Abs(x) + Math.Abs(y)) * -2f;
        transform.rotation = Quaternion.Euler(0, 0, rv+transform.rotation.z);
        //rv -= .2f;


    }
    void LateUpdate() {
        var Colliders = new List<Collider2D>();
        var filter = new ContactFilter2D();
        var overlapping = MyCollider.OverlapCollider(filter, Colliders);
        foreach (var c in Colliders)
        {
            var vector = MyCollider.Distance(c);
            transform.position += new Vector3(vector.normal.x * vector.distance * .15f, vector.normal.y * vector.distance * .15f, 0);
        }
        if(transform.position.x > (screenwidth+2))
        {
            transform.position = new Vector3((screenwidth / -1)-2, transform.position.y, transform.position.z);
        }
        if (transform.position.y > (screenheight + 2))
        {
            transform.position = new Vector3( transform.position.x, (screenheight / -1) - 2, transform.position.z);
        }
        if (transform.position.x < (screenwidth / -1-2))
        {
            transform.position = new Vector3((screenwidth) + 2, transform.position.y, transform.position.z);
        }
        if (transform.position.y < (screenheight / -1-2))
        {
            transform.position = new Vector3(transform.position.x, (screenheight) + 2, transform.position.z);
        }
    }
}
