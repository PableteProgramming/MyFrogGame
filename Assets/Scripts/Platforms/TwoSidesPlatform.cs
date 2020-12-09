using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoSidesPlatform : MonoBehaviour
{
    private PlatformEffector2D effector;
    public bool IsPlayed;
    void Start()
    {
        effector = GetComponent<PlatformEffector2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown("s"))
        {
            if (IsPlayed)
            {
                effector.rotationalOffset = 180f;
            }
        }

        if (Input.GetKeyDown("space") || Input.GetKeyDown("up"))
        {
            effector.rotationalOffset = 0f;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            IsPlayed = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            IsPlayed = false;
        }
    }

}
