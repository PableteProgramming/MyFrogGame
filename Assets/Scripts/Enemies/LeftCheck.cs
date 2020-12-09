using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftCheck : MonoBehaviour
{
    public static bool IsWalled = false;
    public string Tag;
    private void Start()
    {
        IsWalled = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag(Tag))
        {
            IsWalled = true;
            //Debug.Log(IsWalled);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.CompareTag(Tag))
        {
            IsWalled = false;
            //Debug.Log(IsWalled);
        }
    }
}
