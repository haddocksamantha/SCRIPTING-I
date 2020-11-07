using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float speed = 5.0f;
    
    private static int score;
    private float horizontalInput;
    private float verticalInput;
    private float xRange = 15f;

    void Start()
    {
      
    }
    // Update is called once per frame
    void Update()
    {
        Movement();
        OutOfBounds();
        score = ScoreScript.score;
    }

    void Movement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (GameObject.FindGameObjectWithTag("SprayCan"))
        {
            score += 10; 
        }

        if (GameObject.FindGameObjectWithTag("Powerup"))
        {
            speed = 10f;
        }
    }

    void OutOfBounds()
    {
        //x axis boundaries
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange,transform.position.y,transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange,transform.position.y,transform.position.z);
        }
        
    }
}