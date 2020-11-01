using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprayCan : MonoBehaviour
{
    private GameObject sprayCan;

    public GameObject sticker;
    
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
      Instantiate(sticker);
    }
    
    //add powerup timer
    //randomize the sticker instantiation position

}
