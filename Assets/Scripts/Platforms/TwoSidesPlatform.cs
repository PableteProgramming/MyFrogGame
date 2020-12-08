using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoSidesPlatform : MonoBehaviour
{
    private PlatformEffector2D effector;
    void Start()
    {
        effector = GetComponent<PlatformEffector2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown("s"))
        {
            effector.rotationalOffset = 180f;
        }

        if (Input.GetKeyDown("space") || Input.GetKeyDown("up"))
        {
            effector.rotationalOffset = 0f;
        }
    }
}
