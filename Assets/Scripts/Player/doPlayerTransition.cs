using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doPlayerTransition : MonoBehaviour
{
    public GameObject PlayerDecorationObject;
    public string NextSceneName;
    public bool UpdateLevel=false;

    public void DoTransition()
    {
        PlayerDecorationObject.GetComponent<PlayerDecoration>().Desappear(NextSceneName);
        if (UpdateLevel)
        {
            gameObject.GetComponent<LevelController>().UpdateLevel();
        }
        Destroy(gameObject);
    }

}
