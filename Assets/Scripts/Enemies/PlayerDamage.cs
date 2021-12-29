using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log(collision.transform.GetComponent<PlayerLives>().playerLives);
            if (collision.transform.GetComponent<PlayerLives>().playerLives==1)
            {
                collision.transform.GetComponent<PlayerRespawn>().PlayerDamage();
            }
            else
            {
                collision.transform.GetComponent<PlayerLives>().playerLives = collision.transform.GetComponent<PlayerLives>().playerLives-1;
            }
        }
    }
}
