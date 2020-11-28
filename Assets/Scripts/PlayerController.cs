using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float runSpeed;
    public float jumpSpeed;

    public Rigidbody2D rb2d;

    public SpriteRenderer spriteRenderer;

    public Animator animator;

    public bool betterjump;

    public float fallMultiplier;

    public float jumpMultiplier;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey("space") || Input.GetKey("up"))
        {
            if (CheckGround.IsGrounded)
            {
                rb2d.velocity = new Vector2(rb2d.velocity.x, jumpSpeed);
            }
        }

        if (CheckGround.IsGrounded == false)
        {
            animator.SetBool("Jump", true);
            animator.SetBool("Run", false);
        }

        if (CheckGround.IsGrounded == true)
        {
            animator.SetBool("Jump", false);
            animator.SetBool("Fall", false);
        }

        if (rb2d.velocity.y < 0)
        {
            animator.SetBool("Fall", true);
        }
        else if (rb2d.velocity.y > 0)
        {
            animator.SetBool("Fall", false);
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2d.velocity = new Vector2(runSpeed, rb2d.velocity.y);
            spriteRenderer.flipX = false;
            animator.SetBool("Run", true);
            animator.SetBool("Fall", false);
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2d.velocity = new Vector2(-runSpeed, rb2d.velocity.y);
            spriteRenderer.flipX = true;
            animator.SetBool("Run", true);
            animator.SetBool("Fall", false);
        }
        else {
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
            animator.SetBool("Run", false);
        }

        if (betterjump)
        {
            if (rb2d.velocity.y < 0)
            {
                rb2d.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier) * Time.deltaTime;
            }
            if (rb2d.velocity.y > 0 && !Input.GetKey("space") && !Input.GetKey("up"))
            {
                rb2d.velocity += Vector2.up * Physics2D.gravity.y * (jumpMultiplier) * Time.deltaTime;
            }
        }
    }
}
