using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolineJump : MonoBehaviour
{
    public Animator animator;
    public float jumpSpeed;
    public string JumpAnimationName;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.GetComponent<PlayerFakeMoves>().FakeJump(jumpSpeed);
            
            animator.Play(JumpAnimationName);
        }
    }

}
