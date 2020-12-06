using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor;
using UnityEngine;
using Random = UnityEngine.Random;

/*public class Spawner : MonoBehaviour
{
    
    public GameObject sprayCanPrefab;
    public GameObject playerPrefab;
    public GameObject powerUpPrefab;
    public Vector3 playerSpawnPoint;

    private int numberOfCans = 0;
    private Vector3 itemTransform;
    private float itemX;
    private float itemY = -3.627f;
    private float itemZ = -7.869812f;
    private float xRange = 7;
    
    // Start is called before the first frame update
    void Start()
    {
        sprayCanPrefab = GameObject.FindWithTag("SprayCan");
        playerPrefab = GameObject.FindWithTag("Player");
        powerUpPrefab = GameObject.FindWithTag("Powerup");

        playerSpawnPoint = new Vector3(-5.97f, -3.53f, -2.884453f);
        
        SpawnPlayer();
        SpawnPowerup();
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnSprayCan();
    }

    void SpawnPlayer()
    {
        Instantiate(playerPrefab, playerSpawnPoint, Quaternion.identity);
    }

    void SpawnSprayCan()
    {
        if (numberOfCans <= 0)
        {
            ItemTransformGenerator();
            Instantiate(sprayCanPrefab,itemTransform,Quaternion.identity);
        }
    }

    void SpawnPowerup()
    {
        ItemTransformGenerator();
        Instantiate(powerUpPrefab, itemTransform, Quaternion.identity);
    }

    void ItemTransformGenerator()
    {
        itemX = Random.Range(-xRange, xRange);
        itemTransform = new Vector3(itemX, itemY, itemZ);
    }
}
*/
