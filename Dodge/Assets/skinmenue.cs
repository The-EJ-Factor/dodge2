
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skinmenue : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject SkinCanvas;
    // Start is called before the first frame update
    public void switchskinmenue()
    {
        Canvas.SetActive(false);
        SkinCanvas.SetActive(true);
    }
    public void switchsmainmenue()
    {
        Canvas.SetActive(true);
        SkinCanvas.SetActive(false) ;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
