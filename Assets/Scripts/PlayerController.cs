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

    void Start()
    {

    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2d.velocity = new Vector2(runSpeed, rb2d.velocity.y);
            spriteRenderer.flipX = false;
            animator.SetBool("Run", true);
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2d.velocity = new Vector2(-runSpeed, rb2d.velocity.y);
            spriteRenderer.flipX = true;
            animator.SetBool("Run", true);
        }
        else {
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
            animator.SetBool("Run", false);
        }
    }
}
