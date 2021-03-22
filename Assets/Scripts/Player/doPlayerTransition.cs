using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doPlayerTransition : MonoBehaviour
{
    public GameObject PlayerDecorationObject;
    public string NextSceneName;
    public bool UpdateLevel=false;
    private bool AlreadyDone;

    private void Start()
    {
        AlreadyDone = false;
    }

    public void DoTransition()
    {
        if (!AlreadyDone)
        {
            PlayerDecorationObject.GetComponent<PlayerDecoration>().Desappear(NextSceneName);
            if (UpdateLevel)
            {
                gameObject.GetComponent<LevelController>().UpdateLevel();
            }
            AlreadyDone = true;
        }
    }
}
