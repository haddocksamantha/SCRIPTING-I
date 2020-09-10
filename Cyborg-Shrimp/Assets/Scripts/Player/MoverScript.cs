using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverScript : MonoBehaviour
{
    public float speed = 3f;
    public int score = 100;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log( message:"Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        var y = speed * Time.deltaTime * Input.GetAxis("Vertical");
        var x = speed * Time.deltaTime * Input.GetAxis("Horizontal");
        var z = 0;
        transform.Translate(x,y,z);
    }

    public void Up()
    {
        transform.Translate(0, speed, 0);
    }

    public void Down()
    {
        transform.Translate(0, -speed, 0);
    }
}
