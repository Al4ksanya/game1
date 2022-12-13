using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    private Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();        
    }
    private void Update()
    {
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }

        if (Input.GetAxisRaw("Vertical") > 0)
        {
            animator.SetBool("isGoingUp", true);
        }
        else
        {
            animator.SetBool("isGoingUp", false);
        }

        if (Input.GetAxisRaw("Vertical") < 0)
        {
            animator.SetBool("isGoingDown", true);
        }
        else
        {
            animator.SetBool("isGoingDown", false);
        }
    }
}
