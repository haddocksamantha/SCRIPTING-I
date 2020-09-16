using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
In a single script write variables for the following:

Health as a float
Password as a string
Player name as a string
Points as an int
 */
public class Homework : MonoBehaviour
{
    public float health = 100; 
    public string password = ("password"); 
    public string playerName = ("link"); 
    public int points = 0;
    public string keyCode;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (keyCode == "bee")
        {
            print("keycode accepted");
        }
    }
}
