using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesText : MonoBehaviour
{
    public GameObject Player;
    private void Start()
    {
        gameObject.GetComponent<Text>().text = "Lives: Loading...";
    }
    // Update is called once per frame
    void Update()
    {
        int currentLives= Player.GetComponent<PlayerLives>().currentLives;
        if (currentLives == 0)
        {
            //Player loading
            gameObject.GetComponent<Text>().text = "Lives: Loading...";
        }
        else
        {
            int totalLives = Player.GetComponent<PlayerLives>().playerLives;
            string text = "Lives: " + totalLives.ToString() + "/" + currentLives.ToString();
            gameObject.GetComponent<Text>().text = text;
        }
    }
}
