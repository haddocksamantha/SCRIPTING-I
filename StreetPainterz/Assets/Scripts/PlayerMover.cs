using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float speed = 5.0f;
    public float horizontalInput;
    public float verticalInput;

    public float zRange = 15f;
    public float xRange = 15f;

    public int score;

    void Start()
    {
        score = 0; 
    }
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
        
        OutOfBounds();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (GameObject.FindGameObjectWithTag("SprayCan"))
        {
            score++;
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


/*
      //z axis boundaries
      if (transform.position.z < -zRange)
      {
          transform.position = new Vector3(transform.position.x,transform.position.y,-zRange);
      }

      if (transform.position.z > zRange)
      {
          transform.position = new Vector3(transform.position.x,transform.position.y,zRange);
      }
      */
