using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public int numberOfPowerups;
    public int numberOfSprayCans;
    public GameObject powerup;
    public GameObject sprayCan;
    void Start()
    {
      
    }

     void Update()
    {
      SpawnPowerups();
    }

    Vector3 GeneratedPosition()
    {
        int x,y,z;
        x = Random.Range(-8,8);
        y = -2;
        z = 3;
        return new Vector3(x,y,z);
    }

    void SpawnPowerups()
    {
        for(int count = 0; count < numberOfPowerups;)
        {
            Instantiate(powerup, GeneratedPosition(), Quaternion.identity);
        } 
        for(int count = 0; count < numberOfSprayCans;)
        {
            Instantiate(sprayCan, GeneratedPosition(), Quaternion.identity);
        }
    }
}