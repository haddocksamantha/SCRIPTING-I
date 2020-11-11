using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody playerRb;

    private float horizontalInput;
    //private float verticalInput;
    private float xRange = 7f;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        OutOfBounds();
    }
    
    void PlayerMovement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        //verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        //transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
    }
    void OutOfBounds()
    {
        IfOutOfBounds();
    }

    void IfOutOfBounds()
    {
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
