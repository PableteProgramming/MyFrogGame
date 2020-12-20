using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFakeMoves : MonoBehaviour
{
    public static bool IsJumping;
    public static bool IsPlaying;
    public Rigidbody2D rb2d;

    public void FakeJump(float power)
    {
        GetComponent<Rigidbody2D>().velocity = (Vector2.up * power);
        GetComponent<PlayerController>().canDoubleJump = true;
        //GetComponent<PlayerController>().canWallJump = true;
        GetComponent<Animator>().SetBool("Jump", true);
        GetComponent<Animator>().SetBool("DoubleJump", false);
    }

}
