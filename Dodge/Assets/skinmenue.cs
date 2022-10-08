
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skinmenue : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject SkinCanvas;
    public GameObject ShopCanvas;
    public GameObject AchivmentCanvas;
    public GameObject SettingsCanvas;
    public GameObject Show;
    // Start is called before the first frame update  
    public void switchsmainmenue()
    {
        Canvas.SetActive(true);
        Show.SetActive(true);
        Show.transform.position=new Vector3(8.4f,4.6f,-6f);
        SkinCanvas.SetActive(false) ;
        ShopCanvas.SetActive(false);
        AchivmentCanvas.SetActive(false);
        SettingsCanvas.SetActive(false);
    }
    public void switchskinmenue()
    {
        Canvas.SetActive(false);
        SkinCanvas.SetActive(true);
        Show.SetActive(true);
        Show.transform.position=new Vector3(0f,0f,-6f);
    }
  
    public void switchshopmenue(){
        Canvas.SetActive(false);
        ShopCanvas.SetActive(true);
    }
    public void switchachivmentmenue(){
        Canvas.SetActive(false);
        AchivmentCanvas.SetActive(true);
    }
    public void switchsettingsmenue(){
        Canvas.SetActive(false);
        SettingsCanvas.SetActive(true);
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
