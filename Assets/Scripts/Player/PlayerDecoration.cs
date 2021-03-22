using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerDecoration : MonoBehaviour
{
    public bool Appearing;
    public bool Desappearing;
    public GameObject DesappearingObject;
    public GameObject AppearingObject;
    public GameObject PlayerSprite;
    public float AppearingTime;
    public float DesappearingTime;
    private string NextSceneName;
    public bool PointTransition;
    public GameObject PointTranstionObject;
    public float PointTransitiontime=2f;

    private void Start()
    {
        Appear();
    }

    public void Appear()
    {
        if (!Appearing)
        {
            AppearChange();
        }
        else
        {
            AppearingObject.SetActive(true);
            Invoke("AppearChange", AppearingTime);
        } 
    }

    private void AppearChange()
    {
        PlayerSprite.SetActive(true);
        AppearingObject.SetActive(false);
    }

    public void Desappear(string NextScene)
    {
        NextSceneName = NextScene;
        if (Desappearing)
        {
            DesappearingObject.SetActive(true);
            PlayerSprite.SetActive(false);
            Invoke("DesappearChange", DesappearingTime);
        }
        else
        {
            DesappearChange();
        }
    }

    public bool DoesSceneExist(string name)
    {
        for (int i = 0; i < SceneManager.sceneCountInBuildSettings; i++)
        {
            var scenePath = SceneUtility.GetScenePathByBuildIndex(i);
            var lastSlash = scenePath.LastIndexOf("/");
            var sceneName = scenePath.Substring(lastSlash + 1, scenePath.LastIndexOf(".") - lastSlash - 1);

            if (string.Compare(name, sceneName, true) == 0)
                return true;
        }
        return false;
    }

    private void DesappearChange()
    {
        DesappearingObject.SetActive(false);
        if (PointTransition)
        {
            //Do point transition
            PointTranstionObject.SetActive(true);
            Invoke("ExitOrChange", PointTransitiontime);
        }
        else
        {
            ExitOrChange();
        }
        
    }

    private void ExitOrChange()
    {
        if (!DoesSceneExist(NextSceneName))
        {
            Application.Quit();
        }
        else
        {
            SceneManager.LoadScene(NextSceneName);
        }
        //PointTranstionObject.SetActive(false);
    }

}
