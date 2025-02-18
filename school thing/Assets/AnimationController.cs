using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleAnimations();
    }

    private void HandleAnimations()
    {
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger("DoubleJumpTrigger");
        }
        else
        {
            animator.SetTrigger("Idle");
        }
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
