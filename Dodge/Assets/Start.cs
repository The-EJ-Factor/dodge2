using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SwitchScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("The dodge room");
    }
}
