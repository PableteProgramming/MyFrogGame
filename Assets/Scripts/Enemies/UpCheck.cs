using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpCheck : MonoBehaviour
{
    public bool IsDead;

    private void Start()
    {
        IsDead = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            IsDead = true;
        }
    }
}
