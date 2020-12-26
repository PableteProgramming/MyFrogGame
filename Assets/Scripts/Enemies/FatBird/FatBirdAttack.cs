using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatBirdAttack : MonoBehaviour
{
    public bool Saw;
    public GameObject RayCastEndPoint;
    private float distanceRaycast;

    private void Start()
    {
        distanceRaycast = Vector2.Distance(RayCastEndPoint.transform.position, transform.position);
    }

    private void FixedUpdate()
    {
        RaycastHit2D hit2d = Physics2D.Raycast(transform.position, Vector2.down, distanceRaycast);
        if (hit2d.collider != null)
        {
            if (hit2d.collider.CompareTag("Player"))
            {
                Saw = true;
            }
            else
            {
                Saw = false;
            }
        }
        else
        {
            Saw = false;
        }
    }
}
