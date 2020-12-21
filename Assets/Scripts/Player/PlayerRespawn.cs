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
        gameObject.tag = "Untagged";
        Hitted = true;
        animator.Play("Hit");
        Invoke("ChangeScene", 0.1f);
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
