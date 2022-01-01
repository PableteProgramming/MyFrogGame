using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
    public Animator animator;
    public bool Hitted;
    GameObject Checkpoint;

    void Start()
    {
        Hitted = false;
        Checkpoint = null;
    }

    public void PlayerDamage(int lives, GameObject Checkpoints)
    {
        Checkpoint = Checkpoints;
        gameObject.tag = "Untagged";
        Hitted = true;
        animator.Play("Hit");
        if (lives < 1)
        {
            Invoke("ChangeScene", 0.1f);
        }
        else
        {
            Invoke("MoveToCheckPoint", 0.1f);
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void MoveToCheckPoint()
    {
        gameObject.tag = "Player";
        Hitted = false;
        animator.Play("Idle");
        Checkpoint.GetComponent<ChooseCheckPoint>().MoveToCheckpoint();
    }
}
