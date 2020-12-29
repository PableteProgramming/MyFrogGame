using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AllFruitsEat : MonoBehaviour
{
    public GameObject DesappearingObject;
    public bool Disappearing;
    public string MainMenuScene;

    void Update()
    {
        AllFruitsCollected();
    }

    public void AllFruitsCollected()
    {
        if (transform.childCount == 0)
        {
            if (Disappearing)
            {
                DesappearingObject.SetActive(true);
            }
            else
            {
                ChangeScene();
            }
        }
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene(MainMenuScene);
    }
}
