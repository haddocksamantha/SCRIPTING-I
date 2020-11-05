using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  HealthBarManager : MonoBehaviour
{
    private GameObject healthBar;

    public int playerHealth = 100;
    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        StartHealth();
    }

    // Update is called once per frame
    void Update()
    {
        ChangeHealth();
    }

    void StartHealth()
    {
        healthBar = GameObject.FindWithTag("HealthBar");
        player = GameObject.FindWithTag("Player");

    }

    void ChangeHealth()
    {
        //add code to subtract health if player collides with enemy
    }
}
