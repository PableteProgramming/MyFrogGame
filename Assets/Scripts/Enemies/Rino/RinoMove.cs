using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RinoMove : MonoBehaviour
{
    public SpriteRenderer sprite;
    public Animator animator;
    public GameObject LeftCheck;
    public GameObject RightCheck;
    public float speed;
    private float realWalkSpeed;
    public bool moving;
    public bool Left;
    //public bool WallHit;
    //public float WallHitWaitTime;
    //private float WallHitWaitedTime;
    //public float WallHitPower;

    private void Start()
    {
        GetComponent<RinoRayCastDetection>().Left = Left;
        realWalkSpeed = speed;
        //WallHitWaitedTime = 0;
    }

    private void Update()
    {
        /*if (WallHit)
        {
            if (WallHitWaitedTime >= WallHitWaitTime)
            {
                Move();
            }
            else
            {
                WallHitWaitedTime += Time.deltaTime;
            }
        }
        else
        {
            Move();
        }*/
        //
        Move();
        //
        
        
    }

    private void Move()
    {
        GetComponent<RinoRayCastDetection>().Left = Left;
        if (!moving)
        {
            if (GetComponent<RinoRayCastDetection>().Saw)
            {
                moving = true;
            }
        }

        if (moving)
        {
            animator.SetBool("Run", true);
            if (LeftCheck.GetComponent<Check>().IsWalled)
            {
                speed = -realWalkSpeed;
                Left = false;
                sprite.flipX = true;
                moving = false;
                /*if (WallHit)
                {
                    animator.Play("WallHit");
                    WallHitWaitedTime = 0;
                    GetComponent<Rigidbody2D>().velocity = (Vector2.right * WallHitPower);
                }*/
            }
            else if (RightCheck.GetComponent<Check>().IsWalled)
            {
                sprite.flipX = false;
                speed = realWalkSpeed;
                Left = true;
                /*if (WallHit)
                {
                    animator.Play("WallHit");
                    WallHitWaitedTime = 0;
                    GetComponent<Rigidbody2D>().velocity = (Vector2.left * WallHitPower);
                }*/
                moving = false;
                
            }
            /*else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(-GetComponent<Rigidbody2D>().velocity.x, -GetComponent<Rigidbody2D>().velocity.y);
            }*/
            transform.Translate(Vector2.right * (-speed) * Time.deltaTime);
        }
        else
        {
            animator.SetBool("Run", false);
        }
    }
}
