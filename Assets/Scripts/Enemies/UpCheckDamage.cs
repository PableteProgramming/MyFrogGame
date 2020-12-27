using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpCheckDamage : MonoBehaviour
{
    public int lifes;
    public string HitAnimationName;
    public Animator animator;
    public bool Hit;
    public float DeadTime;
    public float FakeJumpSpeed;
    public AudioSource clip;
    private Camera cam;
    public bool Music;


    private void Start()
    {
        cam = Camera.main;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.GetComponent<PlayerFakeMoves>().FakeJump(FakeJumpSpeed);
            if (Hit)
            {
                animator.Play(HitAnimationName);
            }
            else
            {
                DeadTime = 0;
            }


            if (lifes==1)
            {
                if (Music)
                {
                    AudioSource.PlayClipAtPoint(clip.clip, new Vector3(transform.position.x, transform.position.y, cam.transform.position.z), clip.volume);
                }
                Destroy(gameObject,DeadTime);
            }
            else
            {
                lifes--;
            }
            
        }
    }
}
