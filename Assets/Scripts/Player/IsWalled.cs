using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsWalled : MonoBehaviour
{
    public static bool IsWall;
    public bool temp;
    void Start()
    {
        if(transform.GetChild(0).GetComponent<CheckWall>().IsWalled || transform.GetChild(1).GetComponent<CheckWall>().IsWalled)
        {
            IsWall = true;
        }
        else
        {
            IsWall = false;
        }
    }

    void Update()
    {
        if (transform.GetChild(0).GetComponent<CheckWall>().IsWalled || transform.GetChild(1).GetComponent<CheckWall>().IsWalled)
        {
            IsWall = true;
        }
        else
        {
            IsWall = false;
        }
        temp = IsWall;
    }
}
