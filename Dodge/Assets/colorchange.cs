using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorchange : MonoBehaviour
{
    public float hue;
    public Material colour;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hue += Time.deltaTime*0.05f;
        colour.color = Color.HSVToRGB(hue % 1f, 1f, .85f);
        colour.SetColor("_EmissionColor",Color.HSVToRGB(hue % 1f, 1f, .6f,true));
    }
}
