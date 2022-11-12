using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManeger : MonoBehaviour
{
    public static int tokens = 0;
    public int showtokens;
    public static int savetokens;
    public float time;
    public GameObject text;
    public static void givetokens(int add){
        tokens += add;
    }
    // Start is called before the first frame update
    void Start()
    {
        showtokens = savetokens;
        text.GetComponent<Text>().text=showtokens.ToString();
        savetokens = tokens;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (tokens>showtokens && time > 0.5f/((tokens-showtokens)/5)){
            showtokens += 1;
            time=0;
            text.GetComponent<Text>().text=showtokens.ToString();
        }
        else if(time>1f){
           text.SetActive(false);
        }
    }
}
