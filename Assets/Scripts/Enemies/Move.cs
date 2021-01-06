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

    private void Start()
    {
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
