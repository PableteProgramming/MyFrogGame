using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFall : MonoBehaviour
{
    public Transform startPos;
    public Transform endPos;
    public Transform pos;
    bool touching;
    public string Tag;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        touching = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (touching)
        {
            //we have to fall
            if (Vector2.Distance(pos.position, endPos.position) > 0)
            {
                pos.position = Vector2.MoveTowards(pos.position, endPos.position, speed * Time.deltaTime);
            }
            else
            {
                pos.position = endPos.position;
            }
        }
        else
        {
            //we have to go up
            if (Vector2.Distance(pos.position, startPos.position) > 0)
            {
                pos.position = Vector2.MoveTowards(pos.position, startPos.position, speed * Time.deltaTime);
            }
            else
            {
                pos.position = startPos.position;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(Tag))
        {
            //Player touching
            collision.transform.SetParent(transform);
            touching = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(Tag))
        {
            //Player exited
            collision.transform.SetParent(null);
            touching = false;
        }
    }
}
