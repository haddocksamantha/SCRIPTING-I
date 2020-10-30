using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class PlayerTransform : ScriptableObject
{
    public Vector3 playerTransform;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        playerTransform = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
