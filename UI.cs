using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Movement niggi;
    public Text tequillText;
    private int tequilla;

    void Awake()
    {

        GameObject Player = GameObject.Find("ronny dood");
        niggi = Player.GetComponent<Movement>();

    }
    

    void Update()
    {

        tequilla= niggi.tequilla;
        tequillText.text = "    Tequilla: " + tequilla;
        // tequillText.text = ("tequilla"+tequilla);


    }

}



