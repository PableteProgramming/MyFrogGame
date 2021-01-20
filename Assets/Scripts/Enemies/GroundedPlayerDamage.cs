using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedPlayerDamage : MonoBehaviour
{

    public GameObject PlayerCheckGround;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (PlayerCheckGround.GetComponent<CheckGround>().Ground)
            {
                collision.transform.GetComponent<PlayerRespawn>().PlayerDamage();
            }
        }
    }
}
