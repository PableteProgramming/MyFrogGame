using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public SpriteRenderer sprite;
    public GameObject Leftcheck;
    public GameObject Rightcheck;
    public GameObject UpCheck;
    public bool Upcheck;
    public float walkspeed;
    private float realwalkspeed;
    public float waitime;
    private float realwaittime;
    public float waitedTime;
    private bool sleeping;
    private bool moving;
    public bool IsDead;
    public bool SameCheckTag;

    private void Start()
    {
        sleeping = false;
        IsDead = false;
        realwaittime = waitime;
        moving = true;
        waitedTime = 0;
        realwalkspeed = walkspeed;
    }

    void Update()
    {
        
        if (waitedTime >= waitime)
        {
            waitime = realwaittime;
            if (sleeping)
            {
                //rb2d.WakeUp();
                sleeping = false;
                moving = true;
                waitedTime = 0;
            }
            else if (moving)
            {
                //rb2d.Sleep();
                sleeping = true;
                moving = false;
                waitedTime = 0;
            }
        }

        /*if (Upcheck)
        {
            IsDead = UpCheck.GetComponent<UpCheck>().IsDead;
            if (IsDead)
            {
                Destroy(gameObject);
            }
        }*/

        if (SameCheckTag)
        {
            if (Leftcheck.GetComponent<Check>().IsWalled)
            {
                walkspeed = -realwalkspeed;
                sprite.flipX = true;
                waitime = 0;
            }
            else if (Rightcheck.GetComponent<Check>().IsWalled)
            {
                sprite.flipX = false;
                walkspeed = realwalkspeed;
                waitime = 0;
            }
        }
        else
        {
            if (Leftcheck.GetComponent<LeftCheck>().IsWalled)
            {
                walkspeed = -realwalkspeed;
                sprite.flipX = true;
                waitime = 0;
            }
            else if (Rightcheck.GetComponent<RightCheck>().IsWalled)
            {
                sprite.flipX = false;
                walkspeed = realwalkspeed;
                waitime = 0;
            }
        }

        if (moving)
        {
            rb2d.velocity = new Vector2(-walkspeed, rb2d.velocity.y);
        }
        waitedTime += Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (UpCheck)
        {
            IsDead= UpCheck.GetComponent<UpCheck>().IsDead;
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            if (UpCheck)
            {
                if (!IsDead)
                {
                    collision.transform.GetComponent<PlayerRespawn>().PlayerDamage();
                }
                else
                {
                    Destroy(gameObject);
                }
            }
            else
            {
                collision.transform.GetComponent<PlayerRespawn>().PlayerDamage();
            }
        }
    }
}
