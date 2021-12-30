using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public GameObject CheckPoints;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log(collision.transform.GetComponent<PlayerLives>().playerLives);
            //removing one life
            collision.transform.GetComponent<PlayerLives>().playerLives = collision.transform.GetComponent<PlayerLives>().playerLives-1;
            // making the player die
            collision.transform.GetComponent<PlayerRespawn>().PlayerDamage(collision.transform.GetComponent<PlayerLives>().playerLives, CheckPoints);
        }
    }
}
