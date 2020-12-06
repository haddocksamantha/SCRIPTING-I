using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxAnimationScript : MonoBehaviour
{
    public Animator boxAnimation;
    public KeyCode keyB = KeyCode.B;

    // Start is called before the first frame update
    void Start()
    {
        boxAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyB))
        {
            boxAnimation.Play("BoxAnimation");
        }
    }
}
