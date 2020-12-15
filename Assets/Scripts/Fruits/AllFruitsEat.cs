using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AllFruitsEat : MonoBehaviour
{
    public string MainMenuScene;
    void Update()
    {
        AllFruitsCollected();
    }

    public void AllFruitsCollected()
    {
        if (transform.childCount == 0)
        {
            if (SceneManager.GetActiveScene().buildIndex == SceneManager.sceneCountInBuildSettings - 1)
            {
                Application.Quit();
            }
            else
            {
                ChangeScene();
            }
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(MainMenuScene);
    }
}
