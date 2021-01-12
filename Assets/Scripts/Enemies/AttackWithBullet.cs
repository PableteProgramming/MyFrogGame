using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackWithBullet : MonoBehaviour
{
    private float waitedTime;
    public float waitTimeToAttack = 3;
    public Animator animator;
    public GameObject bulletPrefab;
    public Transform launchSpawnPoint;
    public GameObject RayCastSpawnPoint;
    public float LaunchBulletTime=0.5f;

    private void Start()
    {
        waitedTime=waitTimeToAttack;
    }

    private void Update()
    {
        if (waitedTime>=waitTimeToAttack)
        {
            if (RayCastSpawnPoint.GetComponent<RayCastDetection>().Saw)
            {
                waitedTime = 0;
                animator.Play("Attack");
                Invoke("LaunchBullet", LaunchBulletTime);
            }
        }
        else
        {
            waitedTime += Time.deltaTime;
        }
    }

    public void LaunchBullet()
    {
        GameObject newBullet;
        newBullet = Instantiate(bulletPrefab, launchSpawnPoint.position, launchSpawnPoint.rotation);
    }
}
