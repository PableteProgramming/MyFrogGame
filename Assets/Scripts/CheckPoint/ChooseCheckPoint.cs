using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseCheckPoint : MonoBehaviour
{
    public GameObject playerDecoration;
    public GameObject player;
    public GameObject sprite;
    public GameObject[] Checkpoints;
    public GameObject start;

    public void MoveToCheckpoint()
    {
        GameObject currentCheckPoint = null;
        if (Checkpoints.Length > 0)
        {
            for (int i = 0; i < Checkpoints.Length; i++)
            {
                GameObject current = Checkpoints[i];
                if (current.GetComponent<CheckPointDetect>().Passed)
                {
                    currentCheckPoint = current;
                }
            }
            if (currentCheckPoint == null)
            {
                //set to start
                Debug.Log("Moving to start");
                currentCheckPoint = start;
            }
            else
            {
                currentCheckPoint = currentCheckPoint.GetComponent<CheckPointDetect>().SpawnPoint;
            }
        }
        else
        {
            currentCheckPoint = start;
        }
        player.transform.position = currentCheckPoint.transform.position;
        sprite.transform.localPosition = new Vector3(0, 0, 0);
        playerDecoration.GetComponent<PlayerDecoration>().AppearingObject.transform.localPosition = new Vector3(0, 0, 0);
        playerDecoration.GetComponent<PlayerDecoration>().Appear();
    }
}
