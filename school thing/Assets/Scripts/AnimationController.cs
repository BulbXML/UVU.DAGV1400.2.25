using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator animator;
    private SimpleCharacterController characterController;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        characterController = GetComponentInParent<SimpleCharacterController>();

        if (animator == null)
        {
            Debug.LogError("Animator component not found on " + gameObject.name);
        }

        if (characterController == null)
        {
            Debug.LogError("SimpleCharacterController component not found on " + gameObject.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update method called");
        if (animator != null && characterController != null)
        {
            HandleAnimations();
            // Debug.Log("IsGrounded: " + characterController.IsGrounded);
        }
    }

    private void HandleAnimations()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            animator.SetTrigger("RunTrigger");
        }
        else
        {
            animator.SetTrigger("Idle");
        }
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("jump button pressed");
            if (characterController.IsGrounded)
            {
                animator.SetTrigger("JumpTrigger");
                Debug.Log("JumpTrigger set");
            }
            else
            {
                animator.SetTrigger("DoubleJumpTrigger");
                Debug.Log("DoubleJumpTrigger set");
            }
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("ILOVEWALLJUMPS");
        }
        /* if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger("DoubleJumpTrigger");
        }
        else
        {
            animator.SetTrigger("Idle");
        }
        */
        if (Input.GetKeyDown(KeyCode.H))
        {
            animator.SetTrigger("HitTrigger");
        }
        else
        {
            animator.SetTrigger("Idle");
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger("FallTrigger");
        }
        else
        {
            animator.SetTrigger("Idle");
        }
    }
}