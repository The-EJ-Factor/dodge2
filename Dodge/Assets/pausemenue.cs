using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausemenue : MonoBehaviour
{
    public GameObject pausem;
    public GameObject pausebutton;
    public GameObject playbutton;
    public GameObject backbutton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void enablepause() {
        pausem.SetActive(true);
        Time.timeScale = 0f;
        pausebutton.SetActive(false);
        playbutton.SetActive(true);
        backbutton.SetActive(true);
    }
    public void enableplay()
    {
        pausem.SetActive(false);
        Time.timeScale = 1f;
        pausebutton.SetActive(true);
        playbutton.SetActive(false);
        backbutton.SetActive(false);
    }
}
