using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatBirdMove : MonoBehaviour
{
    private bool Dynamic;
    public Rigidbody2D rb2d;
    public Animator animator;
    public float UpSpeed=0.5f;
    public GameObject RayCastSpawnPoint;

    private void Update()
    {

        if (RayCastSpawnPoint.GetComponent<FatBirdAttack>().Saw)
        {
            Dynamic = true;
            rb2d.bodyType = RigidbodyType2D.Dynamic;
        }

        if (Dynamic)
        {
            if (rb2d.velocity.y < 0)
            {
                animator.SetBool("Falling", true);
                animator.SetBool("Grounded", false);
            }
            else
            {
                animator.SetBool("Falling", false);
                animator.SetBool("Grounded", true);
            }
        }
    }
}
