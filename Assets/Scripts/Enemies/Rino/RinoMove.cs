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
    private Vector3 idlepos;

    private void Start()
    {
        GetComponent<RinoRayCastDetection>().Left = Left;
        realWalkSpeed = speed;
        moving = false;
        idlepos = transform.position;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        GetComponent<RinoRayCastDetection>().Left = Left;
        //if not moving yet
        if (!moving)
        {
            if (GetComponent<RinoRayCastDetection>().Saw)
            {
                //Rino has seen the player and starts running
                moving = true;
            }
        }

        //if moving
        if (moving)
        {
            //playing Run animation
            animator.SetBool("Run", true);
            //if it collides with wall
            if (LeftCheck.GetComponent<Check>().IsWalled)
            {
                //changing run direction and flipping sprite
                speed = -realWalkSpeed;
                Left = false;
                sprite.flipX = true;
                moving = false;
                idlepos = transform.position;
            }
            else if (RightCheck.GetComponent<Check>().IsWalled)
            {
                //changing run direction and flipping sprite
                sprite.flipX = false;
                speed = realWalkSpeed;
                Left = true;
                moving = false;
                idlepos = transform.position;
            }
            // make the sprite move
            transform.Translate(Vector2.right * (-speed) * Time.deltaTime);
        }
        else
        {
            // if not moving, set the animation as idle
            animator.SetBool("Run", false);
            transform.position = idlepos;
        }
    }
}
