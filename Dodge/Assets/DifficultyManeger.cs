using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Diff{
    public string name;
    public int health;
    public float alivetime;
    public float enemywait;
    public float enemyspeed;
}
public class DifficultyManeger : MonoBehaviour

{
    public Button selecter;
    public static int Difficulty = 1;
    public static Diff[] difficultysettings={
        new Diff(){name="Easy",health = 5},
        new Diff(){name="Medium",health = 3},
        new Diff(){name="Hard",health = 1}
    };
    public static Diff current=difficultysettings[Difficulty];

    // Start is called before the first frame update
    public void DifficultySwitch(){
        Difficulty += 1;
        Difficulty = Difficulty%3;
        current=difficultysettings[Difficulty];
        selecter.GetComponentInChildren<Text>().text = current.name;
    }
    void Start()
    {
        selecter.GetComponentInChildren<Text>().text = current.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
