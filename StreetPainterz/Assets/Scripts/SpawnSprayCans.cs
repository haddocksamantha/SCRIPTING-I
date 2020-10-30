using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSprayCans : MonoBehaviour
{
    public GameObject canPrefab;
    private float spawnRange = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        canPrefab = GameObject.FindGameObjectWithTag("SprayCan");
        SpawnSprayCans();
        //CanSpawnRange();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    SpawnSprayCans()
    {
        Instantiate(canPrefab, new Vector3(2, 0, 0), canPrefab.transform.rotation);
    }

    CanSpawnRange()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        //get player transform and add x space
        Vector3 randomPos = new Vector3(playerTransform);
    }
}
