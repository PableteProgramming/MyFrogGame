using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinDoor : MonoBehaviour
{
    public GameObject skinsPanel;
    private bool inDoor = false;


    private void Update()
    {
        if (inDoor && Input.GetKey(KeyCode.Space))
        {
            Time.timeScale = 0;
            skinsPanel.gameObject.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            inDoor = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        inDoor = false;
        //skinsPanel.gameObject.SetActive(false);
    }
}
