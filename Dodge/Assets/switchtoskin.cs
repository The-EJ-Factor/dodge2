using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchtoskin : MonoBehaviour
{
    public SpriteRenderer s;
    // Start is called before the first frame update
    void Start()
    {
        s = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        int current = skinswitcher.currentskin;
        Debug.Log(current);
        Debug.Log(skinswitcher.saveskins);
        Debug.Log(s.sprite);
        
        s.sprite = skinswitcher.saveskins[current];
    }
}
