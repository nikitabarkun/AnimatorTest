using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

[RequireComponent(typeof(Animator))]
public class RobotController : MonoBehaviour
{
    private const string CROUCHING_STR = "isCrouching";
    private const string JUMPING_STR = "isJumping";
    private const string MOVING_STR = "isMoving";
    
    [SerializeField] private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        animator.SetBool(CROUCHING_STR, Input.GetKey(KeyCode.LeftControl));

        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetTrigger(JUMPING_STR);
        }

        var horizontalInput = CrossPlatformInputManager.GetAxis("Horizontal");
        
        if (horizontalInput != 0)
        {
            Move(horizontalInput);
        }
        else
        {
            animator.SetBool(MOVING_STR, false);
        }
    }

    private void Move(float scaleToRotateX)
    {
        animator.SetBool(MOVING_STR, true);

        var scale = transform.localScale;
        
        transform.localScale = new Vector3(scaleToRotateX, scale.y, scale.z);
    }
}
