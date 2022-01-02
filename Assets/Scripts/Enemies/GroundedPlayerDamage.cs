using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedPlayerDamage : MonoBehaviour
{

    public GameObject PlayerCheckGround;
    public bool setParent;
    public GameObject CheckPoints;
    public GameObject PlayerParent;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(transform);
            if (PlayerCheckGround.GetComponent<CheckGround>().Ground)
            {
                collision.transform.GetComponent<PlayerLives>().playerLives = collision.transform.GetComponent<PlayerLives>().playerLives - 1;
                collision.transform.GetComponent<PlayerRespawn>().PlayerDamage(collision.transform.GetComponent<PlayerLives>().playerLives, CheckPoints);
            }
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(transform);
            if (PlayerCheckGround.GetComponent<CheckGround>().Ground)
            {
                collision.transform.GetComponent<PlayerLives>().playerLives = collision.transform.GetComponent<PlayerLives>().playerLives - 1;
                collision.transform.GetComponent<PlayerRespawn>().PlayerDamage(collision.transform.GetComponent<PlayerLives>().playerLives, CheckPoints);
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(PlayerParent.transform);
        }
    }
}
