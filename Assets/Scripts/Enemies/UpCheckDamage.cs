using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpCheckDamage : MonoBehaviour
{
    public int lifes;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.GetComponent<PlayerFakeMoves>().FakeJump(5);
            if (lifes==1)
            {
                Destroy(gameObject);
            }
            else
            {
                lifes--;
            }
            
        }
    }
}
