using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    public GameObject optionsPanel;
    public string MainMenuScene;
    public AudioSource clip;

    public void Options()
    {
        Time.timeScale = 0;
        optionsPanel.SetActive(true);
    }

    public void Play()
    {
        Time.timeScale = 1;
        optionsPanel.SetActive(false);
    }

    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(MainMenuScene);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

    public void PlaySound()
    {
        clip.Play();
    }
}
