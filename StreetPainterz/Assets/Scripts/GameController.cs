using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject playerPrefab;
    public float x = 7f;
    public float y = -2f;
    public float z = 3.4f;

    private Vector3 playerSpawnPos;
    
    
    

    void Awake()
    {
        playerPrefab = GameObject.FindWithTag("Player");
    }

    void Start()
    {
        //Instantiate(playerPrefab,new Vector3(x,y,z));
    }
    
}
