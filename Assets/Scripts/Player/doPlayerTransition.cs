using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doPlayerTransition : MonoBehaviour
{
    public GameObject PlayerDecorationObject;
    public string NextSceneName;

    public void DoTransition()
    {
        PlayerDecorationObject.GetComponent<PlayerDecoration>().Desappear(NextSceneName);
    }

}
