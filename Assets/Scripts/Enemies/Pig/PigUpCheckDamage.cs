using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigUpCheckDamage : MonoBehaviour
{
    public Animator animator;
    private bool AlreadyDead;
    public float FakeJumpSpeed;
    public AudioSource clip;
    public Camera cam;

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
                AudioSource.PlayClipAtPoint(clip.clip, new Vector3(transform.position.x, transform.position.y, cam.transform.position.z), clip.volume);
                GetComponent<Move>().enabled=false;
                animator.SetBool("RealDead", true);
                Destroy(gameObject,0.1f);
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
}
