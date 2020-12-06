using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    public Animator playerWalkAnim;
    private float playerSpeed;
    

    private void Start()
    {
        GameObject playerPrefab = GameObject.FindWithTag("Player");
        PlayerMover playerMovementScript = playerPrefab.GetComponent<PlayerMover>();
        playerSpeed = playerMovementScript.speed;
        playerWalkAnim = GetComponent<Animator>();
    }

    void Update()
    {
        PlayerWalkAnimation();
    }

    void PlayerWalkAnimation()
    {
        if (playerSpeed > 0)
        {
            playerWalkAnim.Play("PlayerWalkAnim");
        } else if (playerSpeed <= 0)
        {
            playerWalkAnim.Play("PlayerIdleAnim");
        }
    }
}
