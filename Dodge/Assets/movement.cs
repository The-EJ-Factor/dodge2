using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public enum Yaxis
{
    down=-1,
    up=1,
    none=0
}
public enum Xaxis
{
    left = -1,
    right = 1,
    none = 0
}

public class movement : MonoBehaviour
{
    public BoxCollider2D MyCollider;
    public Rigidbody2D MyBody;
    public float prevx;
    public float prevy;
    public float mv;
    public float rv;
    public float screenwidth;
    public float screenheight;
    public Yaxis CurrentDIY = Yaxis.none;
    public Xaxis CurrentDIX = Xaxis.none;
    public float Bouncieness;
    public static Vector3 bottomleft;
    public static Vector3 topright;
    // Start is called before the first frame update
    void Start()
    {
        PhysicsMaterial2D NewMaterial = new PhysicsMaterial2D();
        NewMaterial.bounciness = 0f;
        NewMaterial.friction = 10f;
        mv = 1;
        MyCollider.sharedMaterial = NewMaterial;
        screenwidth = Camera.main.orthographicSize * Screen.width / Screen.height;
        screenheight = Camera.main.orthographicSize;
        bottomleft = new Vector3(-screenwidth, -screenheight, 0f);
        topright = new Vector3(screenwidth, screenheight, 0f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float xval = Input.GetAxisRaw("Horizontal");
        float yval = Input.GetAxisRaw("Vertical");
        if (Math.Abs(MyBody.velocity.x) < 40)
        {
            MyBody.AddForce(new Vector2(xval * 5f, 0));

        }
        if (Math.Abs(MyBody.velocity.y) < 40)
        {
            MyBody.AddForce(new Vector2(0, yval * 5f));

        }
        if ((xval!=0f||yval!=0f)&&MyBody.angularVelocity < 500)
        {
            MyBody.angularVelocity = MyBody.angularVelocity + 10f;
        }
        if (Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);
            var touchpos = touch.position;
            var x = touchpos.x * (1 / Screen.width) * (topright.x - bottomleft.x) - ((topright.x - bottomleft.x) / 2);
            var y = touchpos.y * (1 / Screen.height) * (topright.y - bottomleft.y) - ((topright.y - bottomleft.y) / 2);
            var d = new Vector2(x, y);
            MyBody.AddForce(new Vector2((x - transform.position.x) / Mathf.Abs(Vector2.Distance(d, transform.position)), (y - transform.position.y) / Mathf.Abs(Vector2.Distance(d, transform.position))));

        }
        /*
        prevx = transform.position.x;
        prevy = transform.position.y;
        var adjusted = Math.Min(8, mv);
        var keyx = Input.GetAxis("Horizontal")==0? 0f:Math.Max(0.3f, Math.Abs(Input.GetAxis("Horizontal")));
        if (Input.GetAxis("Horizontal") < 0f)
            keyx *= -1;
        var keyy = Input.GetAxis("Vertical") ==0? 0f:Math.Max(0.3f, Math.Abs(Input.GetAxis("Vertical")));
        if (Input.GetAxis("Vertical") < 0f)
            keyy *= -1;
        float x = (float)((keyx)*adjusted);
        float y = (float)((keyy)*adjusted);
        if (x != 0 || y != 0)
        {
            mv += .05f;
            if (mv > 8f)
                mv = 8f;
            CurrentDIY = (y < 0) ? Yaxis.down : (y > 0 ? Yaxis.up : Yaxis.none);
            CurrentDIX = (x < 0) ? Xaxis.left : (x > 0 ? Xaxis.right : Xaxis.none);
        }
        else if (mv > 1)
        {
            x += Math.Min(8, mv) * (int)CurrentDIX*0.3f;
            y += Math.Min(8, mv) * (int)CurrentDIY*0.3f;
            mv -= .2f;
        }
        transform.position += new Vector3((float)x * .05f, (float)y * .05f, 0);
        rv += (Math.Abs(x) + Math.Abs(y)) * -2f;
        
        transform.rotation = Quaternion.Euler(0, 0, rv+transform.rotation.z);
        //rv -= .2f; */
        



    }
    void LateUpdate()
    {

        var Colliders = new List<Collider2D>();
        var filter = new ContactFilter2D();
        var overlapping = MyCollider.OverlapCollider(filter, Colliders);
        foreach (var c in Colliders)
        {
            var vector = MyCollider.Distance(c);
            transform.position += new Vector3(vector.normal.x * vector.distance * .15f, vector.normal.y * vector.distance * .15f, 0);
        }
        if (transform.position.x > (screenwidth + 2))
        {
            transform.position = new Vector3((screenwidth / -1) - 2, transform.position.y, transform.position.z);
        }
        if (transform.position.y > (screenheight + 2))
        {
            transform.position = new Vector3(transform.position.x, (screenheight / -1) - 2, transform.position.z);
        }
        if (transform.position.x < (screenwidth / -1 - 2))
        {
            transform.position = new Vector3((screenwidth) + 2, transform.position.y, transform.position.z);
        }
        if (transform.position.y < (screenheight / -1 - 2))
        {
            transform.position = new Vector3(transform.position.x, (screenheight) + 2, transform.position.z);
        }
    }
    void OnTriggerEnter2D(Collider2D C)
    {
        if(C.tag == "Bounce"){
        MyBody.velocity = (new Vector2(-MyBody.velocity.x, -MyBody.velocity.y))*Bouncieness;
            Destroy(C.gameObject);
        }
       
    }
}