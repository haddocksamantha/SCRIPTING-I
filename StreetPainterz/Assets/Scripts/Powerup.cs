using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    private GameObject sprayCan;
    
    public bool powerUpActive = false;
    
    // Start is called before the first frame update
    void Start()
    {
        sprayCan = GameObject.FindWithTag("SprayCan");
        
    } 
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
      Destroy(sprayCan);
      powerUpActive = true;
    }
    
    //add code to add sticker to wall
    //add powerup timer
    //add bool for powerup
}
