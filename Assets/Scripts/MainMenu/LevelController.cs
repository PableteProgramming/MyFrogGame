using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public int nextLevel;
    public int nextWorld;
    
    /*private Tuple<int, int> Split(string c,char d)
    {
        string[] splitted = c.Split(d);
        string world = splitted[0];
        string level = splitted[1];

        Tuple<int, int> r = new Tuple<int, int>(int.Parse(world), int.Parse(level));
        return r;
    }*/

    public void UpdateLevel()
    {
        /*if (!PlayerPrefs.HasKey(VariableName))
        {
            //variable not initialized
            PlayerPrefs.SetString(VariableName, 1 + ";" + 1);
            return;
        }
        string content = PlayerPrefs.GetString(VariableName);
        Tuple<int, int> WandL = Split(content,';');

        if(nextWorld>= WandL.Item1 && nextLevel> WandL.Item2)
        {
            //update
            PlayerPrefs.SetString(VariableName, nextWorld + ";" + nextLevel);
        }
        Debug.Log(PlayerPrefs.GetString(VariableName));*/
        SaveLoad.Load();
        if (nextWorld >= SaveLoad.Game.World && nextLevel > SaveLoad.Game.level)
        {
            //update
            SaveLoad.Game.World = nextWorld;
            SaveLoad.Game.level = nextLevel;
            SaveLoad.Save();
        }
    }
}
