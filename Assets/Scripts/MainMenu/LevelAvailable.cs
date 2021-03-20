using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelAvailable : MonoBehaviour
{
    public int currentLevel;
    public int currentWorld;
    public string VariableName;
    public Sprite Blocked;
    public Sprite Available;

    private Tuple<int, int> Split(string c, char d)
    {
        string[] splitted = c.Split(d);
        string world = splitted[0];
        string level = splitted[1];

        Tuple<int, int> r = new Tuple<int, int>(int.Parse(world), int.Parse(level));
        return r;
    }

    private void Start()
    {
        if (!PlayerPrefs.HasKey(VariableName))
        {
            Debug.Log("Initializing var");
            //variable not initialized
            PlayerPrefs.SetString(VariableName, 1 + ";" + 1);

            if (currentWorld == 1 && currentLevel == 1)
            {
                //available
                gameObject.GetComponent<OpenDoor>().enabled = true;
                Debug.Log("available");
                if (Available != null)
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = Available;
                }
            }
            else
            {
                //closed
                gameObject.GetComponent<OpenDoor>().enabled = false;
                Debug.Log("closed");
                if (Blocked != null)
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = Blocked;
                }
            }

            return;
        }

        string content = PlayerPrefs.GetString(VariableName);

        Tuple<int, int> WandL = Split(content, ';');

        if (currentWorld <= WandL.Item1 && currentLevel <= WandL.Item2)
        {
            //available
            gameObject.GetComponent<OpenDoor>().enabled = true;
            Debug.Log("available "+currentLevel);
            if (Available != null)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = Available;
            }
        }
        else{
            gameObject.GetComponent<OpenDoor>().enabled = false;
            Debug.Log("closed " + currentLevel);
            if (Blocked != null)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = Blocked;
            }
        }

        Debug.Log(PlayerPrefs.GetString(VariableName));
    }
}
