using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RinoMove : MonoBehaviour
{
    public SpriteRenderer sprite;
    public Animator animator;
    public GameObject LeftCheck;
    public GameObject RightCheck;
    public float speed;
    private float realWalkSpeed;
    public bool moving;
    public bool Left;

    private void Start()
    {
        GetComponent<RinoRayCastDetection>().Left = Left;
        realWalkSpeed = speed;
    }

    private void Update()
    {
        GetComponent<RinoRayCastDetection>().Left = Left;
        if (!moving)
        {
            if (GetComponent<RinoRayCastDetection>().Saw)
            {
                moving = true;
            }
        }

        if (moving)
        {
            animator.SetBool("Run", true);
            if (LeftCheck.GetComponent<Check>().IsWalled)
            {
                speed = -realWalkSpeed;
                Left = false;
                sprite.flipX = true;
                moving = false;
            }
            else if (RightCheck.GetComponent<Check>().IsWalled)
            {
                sprite.flipX = false;
                speed = realWalkSpeed;
                Left = true;
                moving = false;
            }
            transform.Translate(Vector2.right * (-speed) * Time.deltaTime);
        }
        else
        {
            animator.SetBool("Run", false);
        }
    }
}
