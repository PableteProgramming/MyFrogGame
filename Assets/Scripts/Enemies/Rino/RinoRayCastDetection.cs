using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RinoRayCastDetection : MonoBehaviour
{
    public bool Saw;
    public Transform RightRayCastEndPoint;
    public Transform LeftRayCastEndPoint;
    private float distance;
    public bool Left;

    private void FixedUpdate()
    {
        RaycastHit2D[] hits;

        if (Left)
        {
            distance = Vector2.Distance(transform.position, LeftRayCastEndPoint.position);
            hits = Physics2D.RaycastAll(transform.position, Vector2.left, distance);
        }
        else
        {
            distance = Vector2.Distance(transform.position, RightRayCastEndPoint.position);
            hits = Physics2D.RaycastAll(transform.position, Vector2.right, distance);
        }

        for (int i = 0; i < hits.Length; i++)
        {
            RaycastHit2D hit = hits[i];
            if (hit.collider != null)
            {
                if (hit.collider.CompareTag("Player"))
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

            if (Saw)
            {
                break;
            }
        }
    }

}
