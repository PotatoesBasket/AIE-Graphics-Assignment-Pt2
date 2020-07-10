using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    float move = 0;
    float turn = 0;
    bool isRunning = false;
    bool isJumping = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();

        move = Input.GetAxis("Vertical");
        turn = Input.GetAxis("Horizontal");
        isRunning = Input.GetKey(KeyCode.LeftShift);
        isJumping = Input.GetKeyDown(KeyCode.Space);

        animator.SetFloat("move", move);
        animator.SetFloat("turn", turn);
        animator.SetBool("isRunning", isRunning);

        if (isJumping)
            animator.SetTrigger("isJumping");
    }
}