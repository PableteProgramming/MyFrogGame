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
    public float DoubleJumpSpeed;
    public bool canDoubleJump;
    public bool DoubleJump;
    private bool Hitted;
    public GameObject appearing;
    public GameObject desappearing;
    public GameObject GroundChecker;

    void Start()
    {
        Hitted = transform.GetComponent<PlayerRespawn>().Hitted;
    }

    void Update()
    {
        appearing.transform.position = transform.position;
        desappearing.transform.position = transform.position;
        Hitted = transform.GetComponent<PlayerRespawn>().Hitted;
        if (!Hitted)
        {
            if (Input.GetKey("space") || Input.GetKey("up"))
            {
                if (GroundChecker.GetComponent<CheckGround>().Ground)
                {
                    if (DoubleJump)
                    {
                        canDoubleJump = true;
                    }
                    rb2d.velocity = new Vector2(rb2d.velocity.x, jumpSpeed);
                }
                else
                {
                    if (DoubleJump)
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

            if (GroundChecker.GetComponent<CheckGround>().Ground == false)
            {
                animator.SetBool("Jump", true);
                animator.SetBool("Run", false);
            }

            if (GroundChecker.GetComponent<CheckGround>().Ground == true)
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

        }
    }

    private void FixedUpdate()
    {
        Hitted = transform.GetComponent<PlayerRespawn>().Hitted;
        if (!Hitted)
        {
            if (Input.GetKey("d") || Input.GetKey("right"))
            {
                rb2d.velocity = new Vector2(runSpeed, rb2d.velocity.y);
                spriteRenderer.flipX = false;
                appearing.GetComponent<SpriteRenderer>().flipX = false;
                desappearing.GetComponent<SpriteRenderer>().flipX = false;
                animator.SetBool("Run", true);
                animator.SetBool("Fall", false);
            }
            else if (Input.GetKey("a") || Input.GetKey("left"))
            {
                rb2d.velocity = new Vector2(-runSpeed, rb2d.velocity.y);
                spriteRenderer.flipX = true;
                appearing.GetComponent<SpriteRenderer>().flipX = true;
                desappearing.GetComponent<SpriteRenderer>().flipX = true;
                animator.SetBool("Run", true);
                animator.SetBool("Fall", false);
            }
            else
            {
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
