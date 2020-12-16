using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float runSpeed;
    public float jumpSpeed;
    private string dir;
    private bool dirChanged;
    public bool WallJump;
    public bool canWallJump;
    public float WallJumpSpeed;

    public Rigidbody2D rb2d;

    public SpriteRenderer spriteRenderer;

    public Animator animator;

    public bool betterjump;

    public float fallMultiplier;

    public float jumpMultiplier;

    public float DoubleJumpSpeed;

    public bool canDoubleJump;

    public bool DoubleJump;

    private bool Hitted;
   //public bool IsWall1;

    void Start()
    {
        Hitted = transform.GetComponent<PlayerRespawn>().Hitted;
    }

    void Update()
    {
        if (!WallJump)
        {
            transform.GetChild(0).gameObject.SetActive(false);
        }
        else
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
        //
        //IsWall1 = IsWalled.IsWall;
        //
        Hitted = transform.GetComponent<PlayerRespawn>().Hitted;
        if (!Hitted)
        {
            if (Input.GetKey("space") || Input.GetKey("up"))
            {
                if (CheckGround.IsGrounded)
                {
                    if (DoubleJump)
                    {
                        canDoubleJump = true;
                    }
                    if (WallJump)
                    {
                        canWallJump = true;
                    }
                    rb2d.velocity = new Vector2(rb2d.velocity.x, jumpSpeed);
                    dirChanged = false;
                }
                else
                {
                    if (IsWalled.IsWall)
                    {
                        if (WallJump)
                        {
                            if (Input.GetKeyDown("space") || Input.GetKeyDown("up"))
                            {
                                if (canWallJump)
                                {
                                    rb2d.velocity = new Vector2(rb2d.velocity.x, WallJumpSpeed);
                                    canWallJump = false;
                                    dirChanged = false;
                                }
                            }
                        }
                    }
                    //
                    else if (DoubleJump)
                    {
                        if (Input.GetKeyDown("space") || Input.GetKeyDown("up"))
                        {
                            if (canDoubleJump)
                            {
                                animator.SetBool("DoubleJump", true);
                                rb2d.velocity = new Vector2(rb2d.velocity.x, DoubleJumpSpeed);
                                canDoubleJump = false;
                            }
                        }
                    }
                }
            }

            if (CheckGround.IsGrounded == false)
            {
                animator.SetBool("Jump", true);
                animator.SetBool("Run", false);
            }

            if (CheckGround.IsGrounded == true)
            {
                if (gameObject.tag != "Player")
                {
                    gameObject.tag = "Player";
                }
                animator.SetBool("Jump", false);
                animator.SetBool("Fall", false);
                animator.SetBool("DoubleJump", false);
            }

            if (rb2d.velocity.y < 0)
            {
                animator.SetBool("Fall", true);
            }
            else if (rb2d.velocity.y > 0)
            {
                animator.SetBool("Fall", false);
            }

            if (dirChanged)
            {
                canWallJump = true;
            }

            /*if (rb2d.velocity.x > 0)
            {
                dir = "right";
            }
            else if (rb2d.velocity.x > 0)
            {
                dir = "left";
            }
            else
            {
                dir = "stop";
            }*/
        }
    }

    private void FixedUpdate()
    {
        Hitted = transform.GetComponent<PlayerRespawn>().Hitted;
        if (!Hitted)
        {
            if (Input.GetKey("d") || Input.GetKey("right"))
            {
                //dirChanged = false;
                if (dir == "left")
                {
                    dirChanged = true;
                }
                dir = "right";
                rb2d.velocity = new Vector2(runSpeed, rb2d.velocity.y);
                spriteRenderer.flipX = false;
                animator.SetBool("Run", true);
                animator.SetBool("Fall", false);
            }
            else if (Input.GetKey("a") || Input.GetKey("left"))
            {
                //dirChanged = false;
                if (dir == "right")
                {
                    dirChanged = true;
                }
                dir = "left";
                rb2d.velocity = new Vector2(-runSpeed, rb2d.velocity.y);
                spriteRenderer.flipX = true;
                animator.SetBool("Run", true);
                animator.SetBool("Fall", false);
            }
            else
            {
                dirChanged = false;
                dir = "stop";
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
}
