using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Tunnel : MonoBehaviour
{
    private Scene scene;

    public string sceneName;
    public GameObject levelText;
    private void Start()
    {
        scene = SceneManager.GetActiveScene();
        levelText.GetComponent<Text>();
    }

    private void Update()
    {
        SceneNameText();
    }

    private void OnTriggerEnter(Collider other)
    {
        SceneToLoad();
    }

    void SceneToLoad()
    {
        if (scene.name == "Level1")
        {
            SceneManager.LoadScene("Level2");
        }else if(scene.name == "Level2")
        {
            SceneManager.LoadScene("Level1");
        }
    }

    void SceneNameText()
    {
        if (scene.name == "Level1")
        {
            levelText.GetComponent<Text>().text = "Level 1";
        }else if (scene.name == "Level2")
        {
            levelText.GetComponent<Text>().text = "Level 2";
        }
    }
    
}
