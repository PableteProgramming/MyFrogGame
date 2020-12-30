using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appearing : MonoBehaviour
{
    public float Time;
    public GameObject player;
    public bool WantAppearing;

    private void Start()
    {
        if (!WantAppearing)
        {
            Time = 0;
        }
        Invoke("Change", Time);
    }

    private void Change()
    {
        player.SetActive(true);
        gameObject.SetActive(false);
    }
}
