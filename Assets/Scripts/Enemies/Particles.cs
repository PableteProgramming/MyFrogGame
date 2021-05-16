using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour
{
    public GameObject particlesPrefab;
    public Transform rightspawnPoint;
    public Transform leftspawnPoint;
    public float waitTime;
    private float waitedTime;
    public GameObject dirDetector;
    public float livingTime = 2;
    int dir;

    private void Start()
    {
        waitedTime = 0;
    }

    private void Update()
    {
        if (waitedTime >= waitTime)
        {
            waitedTime = 0;
            LaunchParticle();
        }
        waitedTime += Time.deltaTime;
    }

    void LaunchParticle()
    {
        dir= dirDetector.GetComponent<Move>().dir;
        GameObject newparticle;
        if (dir <= -1)
        {
            //right
            newparticle = Instantiate(particlesPrefab, rightspawnPoint.position, rightspawnPoint.rotation);
            newparticle.GetComponent<ParticlesRemove>().livingTime = livingTime;
        }
        else if (dir >= 1)
        {
            //left
            newparticle = Instantiate(particlesPrefab, leftspawnPoint.position, leftspawnPoint.rotation);
            newparticle.GetComponent<ParticlesRemove>().livingTime = livingTime;
        }
    }

}
