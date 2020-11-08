using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;
using Random = UnityEngine.Random;

public class SprayCans : MonoBehaviour
{
    private GameObject sprayCan;
    private Vector3 stickerSpawnPos;

    public GameObject sticker;
    public bool powerUpActive = false;
    public int numberOfStickers;
    
    // Start is called before the first frame update
    void Start()
    {
        sprayCan = GameObject.FindWithTag("SprayCan");
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(sprayCan);
        powerUpActive = true;
        PlaceSticker();
        StartCoroutine("PowerUpTimer");
    }

    void PlaceSticker()
    { 
        GeneratePosition();
        Instantiate(sticker,stickerSpawnPos, Quaternion.identity);
        numberOfStickers++;
    }

    void GeneratePosition()
    {
        float x = Random.Range(-9.37f, 4.86f);
        float y = Random.Range(-0.17f, 3.76f);
        float z = -22.11504f;
        stickerSpawnPos = new Vector3(x,y,z);
        transform.position = stickerSpawnPos;
    }

    IEnumerator PowerUpTimer()
    {
        yield return new WaitForSeconds(3);
        powerUpActive = false;
    }
   
    //create an array of stickers or create different spray can prefabs and add different stickers to each?

}