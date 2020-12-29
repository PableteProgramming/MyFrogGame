using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appearing : MonoBehaviour
{
    public float Time;
    public GameObject player;

    private void Start()
    {
        Invoke("Change", Time);
    }

    private void Change()
    {
        player.SetActive(true);
        Destroy(gameObject);
    }
}
