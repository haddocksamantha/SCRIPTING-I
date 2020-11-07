using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PreviousLevel : MonoBehaviour
{
    public bool playerEntered = false;
    void Update()
    {
        PreviousScene();
    }
    
    private void OnTriggerExit(Collider other)
    {
        playerEntered = true;
        Debug.Log("Tunnel Entered");
    }

    void PreviousScene()
    {
        if (playerEntered == true)
        {
            SceneManager.LoadScene("Level1");
        }
    }
}

