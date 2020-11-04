using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
   public GameObject[] objectsToSpawn;
   public float xRange = 6f;
   public int numberOfObjects; 
   
   private int randomNumber;
   private Vector3 spawnPos;

   void Start()
   {
      numberOfObjects = 0;
   }
   
   void Update()
   {
      if (numberOfObjects < 2)
      {
         SpawnRandom();
         RandomTransform();
      }
   }

   void SpawnRandom()
   {
      randomNumber = Random.Range(0, objectsToSpawn.Length);
      Instantiate(objectsToSpawn[randomNumber]);
      numberOfObjects++;
   }

   void RandomTransform()
   {
      float x = Random.Range(-xRange, xRange);
      float y = -1.5f;
      float z = 3.4f;
      spawnPos = new Vector3(x,y,z);
      transform.position = spawnPos;
   }

}