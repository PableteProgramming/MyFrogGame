using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedPlayerDamage : MonoBehaviour
{

    public GameObject PlayerCheckGround;
    public bool setParent;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(transform);
            if (PlayerCheckGround.GetComponent<CheckGround>().Ground)
            {
                collision.transform.GetComponent<PlayerRespawn>().PlayerDamage();
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
                collision.transform.GetComponent<PlayerRespawn>().PlayerDamage();
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }
    }
}
