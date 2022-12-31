using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Achivmentscrollsizemanager : MonoBehaviour
{
    public static int scrollheight;
    public static void SetScrollHeight()
    {scrollheight = AchivmentManager.allachivments.Count*130;}
}
