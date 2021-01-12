using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float speed;
    public enum Direction {right,left,up,down};
    public Direction direction;

    private void Update()
    {
        switch (direction)
        {
            case Direction.left:
                transform.Translate(Vector2.left * speed * Time.deltaTime);
                break;
            case Direction.right:
                transform.Translate(Vector2.right * speed * Time.deltaTime);
                break;
            case Direction.up:
                transform.Translate(Vector2.up * speed * Time.deltaTime);
                break;
            case Direction.down:
                transform.Translate(Vector2.down * speed * Time.deltaTime);
                break;
            default:
                break;
        }
    }

}
