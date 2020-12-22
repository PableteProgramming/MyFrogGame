using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFakeMoves : MonoBehaviour
{
    public Rigidbody2D rb2d;

    public void FakeJump(float power)
    {
        rb2d.velocity = (Vector2.up * power);
        GetComponent<PlayerController>().canDoubleJump = true;
        //GetComponent<PlayerController>().canWallJump = true;
        GetComponent<Animator>().SetBool("Jump", true);
        GetComponent<Animator>().SetBool("DoubleJump", false);
    }

}
