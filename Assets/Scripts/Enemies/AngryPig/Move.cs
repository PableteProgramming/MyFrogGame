using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public SpriteRenderer sprite;
    public float walkspeed;
    private float realwalkspeed;
    public float waitime;
    private float realwaittime;
    public float waitedTime;
    private bool sleeping;
    private bool moving;

    private void Start()
    {
        sleeping = false;
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
        if (LeftCheck.IsWalled)
        {
            walkspeed = -realwalkspeed;
            sprite.flipX = true;
            waitime = 0;
        }
        else if (RightCheck.IsWalled)
        {
            sprite.flipX = false;
            walkspeed = realwalkspeed;
            waitime = 0;
        }
        if (moving)
        {
            rb2d.velocity = new Vector2(-walkspeed, rb2d.velocity.y);
        }
        waitedTime += Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.GetComponent<PlayerRespawn>().PlayerDamage();
        }
    }
}
