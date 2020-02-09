using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Walk()
    {
        animator.Play("walk", -1, 0f);
    }

    public void Jump()
    {
        animator.Play("jump", -1, 0f);
    }

    public void Hit1()
    {
        animator.Play("hit01", -1, 0f);
    }

    public void Hit2()
    {
        animator.Play("hit02", -1, 0f);
    }
}
