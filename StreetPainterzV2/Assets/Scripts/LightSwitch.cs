using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class LightSwitch : MonoBehaviour
{
    public bool playerOn = false;
    public GameObject spotLight;

    void Start()
    {
        spotLight = GameObject.Find("SpotLight");
        spotLight.SetActive(false);
    }
    private void OnTriggerStay(Collider other)
    {
        if (GameObject.FindWithTag("Player"))
        {
            playerOn = true;
            spotLight.SetActive(true);
            Debug.Log("Light On");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
 
    }

    private void OnTriggerExit(Collider other)
    {
        if (GameObject.FindWithTag("Player"))
        { 
            playerOn = false;
            spotLight.SetActive(false);
        }
    }

    
}
