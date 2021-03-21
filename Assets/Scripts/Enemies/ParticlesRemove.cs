using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlesRemove : MonoBehaviour
{
    public float livingTime;
    float livedTime;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        livedTime = 0;
    }

    private void Update()
    {
        if(livedTime>= livingTime)
        {
            Destroy(gameObject);
        }
        livedTime += Time.deltaTime;
    }
}
