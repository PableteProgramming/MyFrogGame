using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLives : MonoBehaviour
{
    public int playerLives;
    public int currentLives;
    // Start is called before the first frame update
    void Start()
    {
        currentLives = playerLives;
    }
}
