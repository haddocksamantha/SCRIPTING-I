using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    private GameObject powerup;
    public bool speedPoweredUp = false;

    void Start()
    {
        powerup = GameObject.FindWithTag("Powerup");

    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(powerup);
        speedPoweredUp = true;
    }
}
