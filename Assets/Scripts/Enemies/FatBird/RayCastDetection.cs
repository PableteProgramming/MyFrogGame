using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastDetection : MonoBehaviour
{
    public bool Saw;
    public Transform RayCastEndPoint;
    private float distanceRaycast;
    public enum Direction {right,left,down,up};
    public Direction dir;
    public string Tag;

    /*private void Update()
    {
        switch (dir)
        {
            case Direction.down:
                Debug.DrawRay(transform.position, Vector2.down * distanceRaycast,Color.red);
                break;
            case Direction.up:
                Debug.DrawRay(transform.position, Vector2.up * distanceRaycast,Color.red);
                break;
            case Direction.right:
                Debug.DrawRay(transform.position, Vector2.right * distanceRaycast, Color.red);
                break;
            case Direction.left:
                Debug.DrawRay(transform.position, Vector2.left * distanceRaycast, Color.red);
                break;
            default:
                break;
        }
    }*/

    private void FixedUpdate()
    {
        distanceRaycast = Vector2.Distance(transform.position, RayCastEndPoint.position);

        RaycastHit2D[] hits;

        switch (dir)
        {
            case Direction.down:
                hits = Physics2D.RaycastAll(transform.position, Vector2.down, distanceRaycast);
                break;
            case Direction.up:
                hits = Physics2D.RaycastAll(transform.position, Vector2.up, distanceRaycast);
                break;
            case Direction.right:
                hits = Physics2D.RaycastAll(transform.position, Vector2.right, distanceRaycast);
                break;
            case Direction.left:
                hits = Physics2D.RaycastAll(transform.position, Vector2.left, distanceRaycast);
                break;
            default:
                hits = null;
                break;
        }

        for (int i = 0; i < hits.Length; i++)
        {
            RaycastHit2D hit = hits[i];
            if (hit.collider != null)
            {
                if (hit.collider.CompareTag(Tag))
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
