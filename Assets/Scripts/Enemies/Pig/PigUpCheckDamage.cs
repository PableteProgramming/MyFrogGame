using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigUpCheckDamage : MonoBehaviour
{
    public Animator animator;
    private bool AlreadyDead;
    public float FakeJumpSpeed;
    public AudioSource clip;
    public GameObject PlayerDamage;

    private void Start()
    {
        AlreadyDead = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.GetComponent<PlayerFakeMoves>().FakeJump(FakeJumpSpeed);
            if (AlreadyDead)
            {
                GetComponent<Move>().enabled=false;
                animator.SetBool("RealDead", true);
                Invoke("Die", 0.1f);
                
            }
            else
            {
                AlreadyDead = true;
                animator.SetBool("Dead", true);
                GetComponent<Move>().realwalkspeed = GetComponent<Move>().realwalkspeed * 4;
                GetComponent<Move>().walkspeed = GetComponent<Move>().walkspeed * 4;
            }
        }
    }

    private void Die()
    {
        PlayerDamage.SetActive(false);
        GetComponent<Collider2D>().enabled = false;
        GetComponent<SpriteRenderer>().enabled = false;
        clip.Play();
        Destroy(gameObject, clip.clip.length);
    }
}
