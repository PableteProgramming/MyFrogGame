using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenDoor : MonoBehaviour
{
    //public string levelScene;
    private bool inDoor = false;
    //public bool PlayerDecorationDesappearing;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            inDoor = true;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            inDoor = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        inDoor = false;
    }

    private void Update()
    {
        if (inDoor && Input.GetKey(KeyCode.Space))
        {
            GetComponent<doPlayerTransition>().DoTransition();
            //SceneManager.LoadScene(levelScene);
        }
    }
}
