using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;
using Random = UnityEngine.Random;

public class SprayCan : MonoBehaviour
{
    private GameObject sprayCan;
    private float xRange = 8f;
    private Vector3 stickerSpawnPos;

    public GameObject sticker;
    public bool powerUpActive = false;
    public int numberOfStickers;
    
    // Start is called before the first frame update
    void Start()
    {
        sprayCan = GameObject.FindWithTag("SprayCan");
        
    } 
    void Update()
    {
        
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
        float x = Random.Range(-xRange, xRange);
        float y = Random.Range(-0.34f, 7.23f);
        float z = -1.8f;
        stickerSpawnPos = new Vector3(x,y,z);
        transform.position = stickerSpawnPos;
    }

    IEnumerator PowerUpTimer()
    {
        yield return new WaitForSeconds(3);
        powerUpActive = false;
    }
   
    //create an array of stickers

}
