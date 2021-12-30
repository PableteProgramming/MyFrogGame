using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitPassed : MonoBehaviour
{
    public bool passed;
    // Start is called before the first frame update
    void Start()
    {
        passed = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            passed = true;
        }
    }
}
