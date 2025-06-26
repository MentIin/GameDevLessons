using System;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    public Animator Animator;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Animator.SetBool("isJumping", true);
            Animator.SetFloat("speed", 123f);
            Animator.SetTrigger("Attack");
        }
    }
}
