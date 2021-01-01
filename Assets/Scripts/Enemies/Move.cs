using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public SpriteRenderer sprite;
    public GameObject Leftcheck;
    public GameObject Rightcheck;
    public float walkspeed;
    public float realwalkspeed;
    private float waitime;
    private float waitedTime;
    private bool sleeping;
    private bool moving;

    private void Start()
    {
        sleeping = false;
        moving = true;
        waitime = 0;
        waitedTime = 0;
        realwalkspeed = walkspeed;
    }

    void Update()
    {
        if (Leftcheck.GetComponent<Check>().IsWalled)
        {
            walkspeed = -realwalkspeed;
            sprite.flipX = true;
        }
        else if (Rightcheck.GetComponent<Check>().IsWalled)
        {
            sprite.flipX = false;
            walkspeed = realwalkspeed;
        }
        transform.Translate(Vector2.right*(-walkspeed)*Time.deltaTime);
    }
}
