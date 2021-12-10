using System.Collections;
using System.Collections.Generic;
using Unity.MLAgents;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool jumpPressed = Input.GetKey(KeyCode.Space);
        bool isJumping = animator.GetBool("isJumping");
        if (!isJumping && jumpPressed)
        {
            animator.SetBool("isJumping", true);
        }
        if (!jumpPressed && isJumping)
        {
            animator.SetBool("isJumping", false);
        }

    }

    void FixedUpdate()
    {

    }
}
