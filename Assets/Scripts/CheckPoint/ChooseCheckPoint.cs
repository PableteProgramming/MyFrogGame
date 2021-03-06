using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseCheckPoint : MonoBehaviour
{
    public GameObject playerDecoration;
    public GameObject player;
    public GameObject sprite;
    public GameObject currentCheckpoint;
    public GameObject start;

    private void Start()
    {
        currentCheckpoint = start;
    }

    public void MoveToCheckpoint()
    {
        sprite.transform.SetParent(player.transform);
        if (currentCheckpoint == start)
        {
            player.transform.position = currentCheckpoint.transform.position;
        }
        else
        {
            player.transform.position = currentCheckpoint.GetComponent<CheckPointDetect>().SpawnPoint.transform.position;
        }
        sprite.transform.localPosition = new Vector3(0, 0, 0);
        playerDecoration.GetComponent<PlayerDecoration>().AppearingObject.transform.localPosition = new Vector3(0, 0, 0);
        playerDecoration.GetComponent<PlayerDecoration>().Appear();
    }
}
