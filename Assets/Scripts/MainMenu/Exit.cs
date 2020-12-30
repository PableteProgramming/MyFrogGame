using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    private bool inDoor = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //text.gameObject.SetActive(true);
            inDoor = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //text.gameObject.SetActive(false);
        inDoor = false;
    }

    private void Update()
    {
        if (inDoor && Input.GetKey(KeyCode.Space))
        {
            GetComponent<doPlayerTransition>().DoTransition();
            //Application.Quit();
        }
    }
}
