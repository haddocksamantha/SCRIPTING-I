using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Target : MonoBehaviour
{
    private Rigidbody targetRb;

    //range variables 
    //used in force
    private float minSpeed = 12;
    private float maxSpeed = 16;

    //used for torque
    private float maxTorque = 10;

    //used for position
    private float xRange = 4;
    private float ySpawnPos = -6;

    // Start is called before the first frame update
    void Start()
    {
        //get rigidbody
        targetRb = GetComponent<Rigidbody>();
        //call random methods
        targetRb.AddForce(RandomForce(), ForceMode.Impulse);
        targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque()), ForceMode.Impulse);
        transform.position = RandomSpawnPos();

    }

    // Update is called once per frame
    void Update()
    {

    }

    Vector3 RandomForce()
    {
        //launch object up at random range
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    float RandomTorque()
    {
        //make object spin (temporarily) aka add torque at a random range as well
        return Random.Range(-maxTorque, maxTorque);
    }

    Vector3 RandomSpawnPos()
    {
        //randomize positions
        return new Vector3(Random.Range(-xRange, xRange),ySpawnPos);
    }
    
}
