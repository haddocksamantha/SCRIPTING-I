using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTriggerScript : MonoBehaviour
{
    public Animator animationEx;
    
    // Start is called before the first frame update
    void Start()
    {
        animationEx = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
      AnimationKeyPress();  
    }

    void AnimationKeyPress()
    {
        if(Input.GetKeyDown("A"))
        {
            animationEx.Play("AnimationExample");
        }
    }
}
