using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AllFruitsEat : MonoBehaviour
{
    void Update()
    {
        AllFruitsCollected();
    }

    public void AllFruitsCollected()
    {
        if (transform.childCount == 0)
        {
            GetComponent<doPlayerTransition>().DoTransition();
        }
    }
}
