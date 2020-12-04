using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    public Animator playerWalkAnim;

    private void Start()
    {
        playerWalkAnim = GetComponent<Animator>();
    }

    void Update()
    {
        PlayerWalkAnimation();
    }

    void PlayerWalkAnimation()
    {
        if (Input.GetKeyDown("Horizontal"))
        {
            playerWalkAnim.Play("PlayerWalkAnim");
        }else if (Input.GetKeyUp("Horizontal"))
        {
            playerWalkAnim.Play("PlayerIdleAnim");
        }
    }
}
