using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCheck : MonoBehaviour
{
    public static bool IsWalled = false;
    private void Start()
    {
        IsWalled = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Ground"))
        {
            IsWalled = true;
            //Debug.Log(IsWalled);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Ground"))
        {
            IsWalled = false;
            //Debug.Log(IsWalled);
        }
    }
}
