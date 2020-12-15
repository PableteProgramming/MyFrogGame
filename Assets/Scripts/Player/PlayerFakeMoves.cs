using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFakeMoves : MonoBehaviour
{
    public static bool IsJumping;
    public static bool IsPlaying;
    private float jumpower;
    private float jumpedpower;
    private float jumpowerperframe;
    public Rigidbody2D rb2d;

    public void FakeJump(float power,float powerperframe)
    {
        IsJumping = true;
        IsPlaying = true;
        jumpower = power;
        jumpedpower = 0f;
        jumpowerperframe = powerperframe;
    }

    private void Update()
    {
        if (IsPlaying)
        {
            if (IsJumping)
            {
                if (jumpedpower<jumpower)
                {
                    rb2d.velocity = new Vector2(rb2d.velocity.x, jumpowerperframe);
                    jumpedpower += jumpowerperframe;
                }
                else
                {
                    IsJumping = false;
                    IsPlaying = false;
                }
            }
        }
    }

}
