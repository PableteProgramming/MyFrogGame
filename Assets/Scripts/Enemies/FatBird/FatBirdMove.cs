using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatBirdMove : MonoBehaviour
{
    private bool Dynamic;
    public Rigidbody2D rb2d;
    public Animator animator;
    public float UpSpeed=0.5f;
    private bool Grounded;
    public GameObject GroundChecker;
    private Vector2 startPos;
    private bool CanFall;
    private bool GoingUp;
    public float GroundedWaitTime;
    private float GroundedWaitedTime;
    public float FallSpeed;
    public bool ArtificialIntelligence;

    private void Start()
    {
        startPos = transform.position;
        GroundedWaitedTime = 0;
        CanFall = true;
        Dynamic = false;
    }

    private void Update()
    {
        //When going up/back to his start position
        if (GoingUp)
        {
            if (Dynamic)
            {
                Dynamic = false;
                rb2d.gravityScale = 0;
            }
            transform.position = Vector2.MoveTowards(transform.position,startPos,UpSpeed*Time.deltaTime);
        }

        //If it his back to his start position
        if (Vector2.Distance(transform.position,startPos)<0.1f)
        {
            if (ArtificialIntelligence)
            {
                GetComponent<ArtificalInteligence>().enabled = true;
            }
            GoingUp = false;
        }

        //Detect if FatBird is Grounded
        Grounded = GroundChecker.GetComponent<GroundCheck>().IsGrounded;

        //Checking if raycast collides with player
        if (GetComponent<RayCastDetection>().Saw)
        {
            if (CanFall)
            {
                if (ArtificialIntelligence)
                {
                    GetComponent<ArtificalInteligence>().enabled = false;
                }
                Dynamic = true;
                rb2d.gravityScale = 1;
                GoingUp = false;
            }
        }

        //Detecting if playing Falling anim
        if (Dynamic)
        {
            if (rb2d.velocity.y < 0)
            {
                animator.SetBool("Falling", true);
            }
            else
            {
                animator.SetBool("Falling", false);
            }
        }


        //If grounded
        if (Grounded)
        {
            animator.SetBool("Grounded", true);
            animator.SetBool("Falling", false);
            if (!GoingUp)
            {
                GroundedWaitedTime += Time.deltaTime;
                if (GroundedWaitedTime>=GroundedWaitTime)
                {
                    GroundedWaitedTime = 0;
                    GoingUp = true;
                }
                
            }
        }
        else
        {
            CanFall = true;
            animator.SetBool("Grounded", false);
            if (Dynamic)
            {
                rb2d.velocity += Vector2.up * FallSpeed * Physics2D.gravity.y * Time.deltaTime;
            }
        }

    }
}
