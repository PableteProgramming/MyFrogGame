using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AllFruitsEat : MonoBehaviour
{
    public string MainMenuScene;
    public GameObject Player;
    public string DesappearingAnimationName;
    public float DesappearingTime;
    public bool Disappearing;

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
                Player.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                Player.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
                Player.gameObject.GetComponent<PlayerController>().Started = false;
                //Player.gameObject.GetComponent<Rigidbody2D>().gameObject.SetActive(false);
                Player.gameObject.GetComponent<BoxCollider2D>().enabled = false;
                Player.gameObject.GetComponent<Animator>().Play(DesappearingAnimationName);
                Invoke("ChangeScene", DesappearingTime);
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
