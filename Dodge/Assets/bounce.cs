using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce : MonoBehaviour
    
{
    public BoxCollider2D MyCollider;
    // Start is called before the first frame update
    void Start()
    {
        PhysicsMaterial2D NewMaterial = new PhysicsMaterial2D();
        NewMaterial.bounciness = 1.0001f;
        NewMaterial.friction = 0f;
        MyCollider.sharedMaterial = NewMaterial;

    }

    // Update is called once per frame
    void Update()
    {
        var C = transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color;
        transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = new Color(C.r, C.g, C.b, C.a - 0.0001f);
        var C2 = transform.GetChild(1).gameObject.GetComponent<SpriteRenderer>().color;
        transform.GetChild(1).gameObject.GetComponent<SpriteRenderer>().color = new Color(C2.r, C2.g, C2.b, C2.a - 0.0001f);
        if (C.a < 0.0000001f)
        {
            Destroy(gameObject);
        }
    }
}
