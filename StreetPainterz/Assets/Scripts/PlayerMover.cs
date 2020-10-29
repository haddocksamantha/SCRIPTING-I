using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float speed = 5.0f;

    private Rigidbody playerRigidbody;
    private Vector3 moveDirection;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(moveDirection * speed * Time.deltaTime);
        }
    }
}
