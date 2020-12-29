using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Desappearing : MonoBehaviour
{
    public string MainMenuScene;
    public float Time;
    public GameObject player;

    private void Start()
    {
        player.SetActive(false);
        Invoke("Change", Time);
    }

    private void Change()
    {
        Destroy(gameObject);
        SceneManager.LoadScene(MainMenuScene);
    }
}
