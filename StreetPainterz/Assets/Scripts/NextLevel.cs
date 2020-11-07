using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public bool playerEntered = false;
    void Update()
    {
        NextScene();
    }
    
    private void OnTriggerExit(Collider other)
    {
        playerEntered = true;
        Debug.Log("Tunnel Entered");
    }

    void NextScene()
    {
        if (playerEntered == true)
        {
            SceneManager.LoadScene("Level2");
        }
    }
}
