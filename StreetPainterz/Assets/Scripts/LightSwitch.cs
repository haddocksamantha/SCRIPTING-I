using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class LightSwitch : MonoBehaviour
{
    public bool playerOn = false;
    public GameObject pinkLight;

    void Start()
    {
        pinkLight = GameObject.Find("Pink Light");
        pinkLight.SetActive(false);
    }
    private void OnTriggerStay(Collider other)
    {
        if (GameObject.FindWithTag("Player"))
        {
            playerOn = true;
            pinkLight.SetActive(true);
            Debug.Log("Light On");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (GameObject.FindWithTag("Player"))
        { 
            playerOn = false;
           pinkLight.SetActive(false);
        }
    }
}
