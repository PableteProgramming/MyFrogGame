using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLives : MonoBehaviour
{
    public int playerLives;
    private int currentLives;
    // Start is called before the first frame update
    void Start()
    {
        currentLives = playerLives;
    }
}
