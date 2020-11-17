using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
   public int maxHealth = 5;
   public int currentHealth;
    
   public HealthBar healthBar;
    
   void Start()
   {
      currentHealth = maxHealth;
      healthBar = GetComponent<HealthBar>();
      healthBar.SetMaxHealth(maxHealth);
      
   }
    
   private void OnCollisionEnter(Collision other)
   {
      if (GameObject.FindWithTag("Enemy"))
      {
         EnemyDamage(1);
         Debug.Log("Enemy Collision");
      }
   }

   void EnemyDamage(int damage)
   {
      currentHealth -= damage;
      healthBar.SetHealth(currentHealth);
   }
}

