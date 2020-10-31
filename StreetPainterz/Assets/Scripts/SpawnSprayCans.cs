using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSprayCans : MonoBehaviour
{
    void Start()
    {
        
    }

    private void Update()
    {
     
    }
}


/*
   public GameObject canPrefab;
   private float spawnRange = 10f;

   // Start is called before the first frame update
   void Start()
   {
       canPrefab = GameObject.FindGameObjectWithTag("SprayCan");
       SpawnSprayCan();
       CanSpawnRange();
   }

   // Update is called once per frame
   void Update()
   {

   }

   void SpawnSprayCan()
   {
       Instantiate(canPrefab, randomPos, canPrefab.transform.rotation);
   }

   void CanSpawnRange()
   {
   public float spawnPosX = Random.Range(-spawnRange, spawnRange);
   private Vector3 randomPos = new Vector3(spawnPosX, 0, 0);
   }
*/