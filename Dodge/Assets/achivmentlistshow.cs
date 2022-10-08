using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class achivmentlistshow : MonoBehaviour
{
    public GameObject contentlist;
    public GameObject achivmentprefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void reshowitems()
    {
        int currenty=0;
        foreach (var achivment in AchivmentManager.allachivments)
        {
            var added = Instantiate(achivmentprefab,contentlist.transform);
            added.SetActive(true);
            added.transform.position+= new Vector3(0f,-currenty, 0f);
            added.transform.GetChild(0).GetComponent<Text>().text=achivment.name;
            added.transform.GetChild(1).GetComponent<Text>().text=achivment.description;
            if(achivment.gotten)
            {
                Debug.Log(achivment.name+" gotten");
            }
            else{
                Debug.Log(achivment.name+" not gotten");
                added.GetComponent<Image>().color= new Color(1f,1f,1f,.5f);
            }
            currenty+= 130;
        }
    }
}
