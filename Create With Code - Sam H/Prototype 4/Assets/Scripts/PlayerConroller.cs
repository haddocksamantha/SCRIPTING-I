using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class PlayerConroller : MonoBehaviour
{
    //public variables
    public float speed = 5.0f;
    public bool hasPowerup = false;
    public GameObject powerUpIndicator;
    
    //private variables
    private Rigidbody playerRb;
    private GameObject focalPoint;
    private float powerUpStrength = 15.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        //finds empty named focal point
        focalPoint = GameObject.Find("Focal Point");
        //evokes countdown
        StartCoroutine(PowerupCountdownRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        //gets vertical keys
        float forwardInput = Input.GetAxis("Vertical");
        //moves player forward
        playerRb.AddForce(focalPoint.transform.forward * forwardInput * speed);
        powerUpIndicator.transform.position = transform.position + new Vector3(0, 0.5f, 0);
    }

    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(7);
        hasPowerup = false;
        powerUpIndicator.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        //gives player powerup and destroys asset
        if (other.CompareTag("Powerup"))
        { 
            hasPowerup = true;
            Destroy(other.gameObject);
            powerUpIndicator.gameObject.SetActive(true);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && hasPowerup)
        {
            Rigidbody enemyRb = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = collision.gameObject.transform.position - transform.position;
            
            Debug.Log("Collided with:" + collision.gameObject.name + "with powerup set to" + hasPowerup);
            enemyRb.AddForce(awayFromPlayer*powerUpStrength,ForceMode.Impulse);
        }
    }
}
