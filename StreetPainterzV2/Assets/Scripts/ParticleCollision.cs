using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCollision : MonoBehaviour
{
    public ParticleSystem glitter;
    
    // Start is called before the first frame update
    void Start()
    {
        glitter.GetComponent<ParticleSystem>().enableEmission = false;
    }
    
    void OnTriggerEnter(Collider other)
    {
        glitter.GetComponent<ParticleSystem>().enableEmission = true;
    }

    private void OnTriggerExit(Collider other)
    {
        glitter.GetComponent<ParticleSystem>().enableEmission = false;
    }
}
