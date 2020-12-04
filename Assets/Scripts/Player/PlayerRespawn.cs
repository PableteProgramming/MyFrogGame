using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
    public Animator animator;
    public bool Hitted;

    void Start()
    {
        Hitted = false;
    }

    public void PlayerDamage()
    {
        Hitted = true;
        animator.Play("Hit");
        Invoke("ChangeScene", 0.5f);
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
