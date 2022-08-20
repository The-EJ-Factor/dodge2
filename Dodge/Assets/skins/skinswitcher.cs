using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skinswitcher : MonoBehaviour
{
    public static int currentskin;
    public static Sprite[] saveskins;
    public Sprite[] allskins;
    public SpriteRenderer S;    // Start is called before the first frame update
    public void nextskin()
    {
        currentskin += 1;
    }
    public void prevskin()
    {
        currentskin -= 1;
    }
    void Start()
    {

        Sprite[] nS = new Sprite[allskins.Length];

        for(int i = 0; i < allskins.Length; i++)
        {
            nS[i] = allskins[i];
        }

        saveskins = nS;

    }

    // Update is called once per frame
    void Update()
    {
        if (currentskin >= 0 && currentskin < allskins.Length)
        {
            S.sprite = allskins[currentskin];
        }
        else
        {
            if (currentskin < 0)
            {
                currentskin = allskins.Length - 1;
            }
            else 
            {
                currentskin = 0;
            }
        }
    }
}
