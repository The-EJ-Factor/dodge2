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
        
    }
}
