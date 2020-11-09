using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyHealth;
    public Rigidbody enemyRb;

    private bool collidingWithPlayer;

    void Start()
    {
        enemyHealth = 5;
        enemyRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        PlayerCollision();
        EnemyDeath();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (collidingWithPlayer == true)
        {
            enemyHealth -= 1;
        }
    }

    void PlayerCollision()
    {
        if (GameObject.FindWithTag("Player"))
        {
            collidingWithPlayer = true;
        } else if(!GameObject.FindWithTag("Player"))
        {
            collidingWithPlayer = false;
        }
    }

    void EnemyDeath()
    {
        if (enemyHealth <= 0)
        {
            Destroy(enemyRb);  
        }
    }
}
