﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public SpriteRenderer sprite;
    public GameObject Leftcheck;
    public GameObject Rightcheck;
    public Rigidbody2D rb2d;
    public float walkspeed;
    public float realwalkspeed;
    private bool moving;

    private void Start()
    {
        moving = true;
        realwalkspeed = walkspeed;
    }

    void Update()
    {
        if (moving)
        {
            moving = false;
        }
        else
        {
            moving = true;
        }

        if (Leftcheck.GetComponent<Check>().IsWalled)
        {
            walkspeed = -realwalkspeed;
            sprite.flipX = true;
        }
        else if (Rightcheck.GetComponent<Check>().IsWalled)
        {
            sprite.flipX = false;
            walkspeed = realwalkspeed;
        }

        if (moving)
        {
            rb2d.velocity = new Vector2(-walkspeed, rb2d.velocity.y);
        }
    }
}
