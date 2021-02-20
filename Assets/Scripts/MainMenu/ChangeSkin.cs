using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkin : MonoBehaviour
{
    public GameObject skinsPanel;
    private bool inDoor = false;
    public GameObject player;

    private void Update()
    {
        if (inDoor && Input.GetKey(KeyCode.Space))
        {
            skinsPanel.gameObject.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            inDoor = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        inDoor = false;
        skinsPanel.gameObject.SetActive(false);
    }


    public void SetPlayerFrog()
    {
        PlayerPrefs.SetString("PlayerSelected", "Frog");
        ResetPlayerSkin();
    }

    public void SetPlayerBlueFrog()
    {
        PlayerPrefs.SetString("PlayerSelected", "BlueFrog");
        ResetPlayerSkin();
    }

    public void SetPlayerOrangeFrog()
    {
        PlayerPrefs.SetString("PlayerSelected", "OrangeFrog");
        ResetPlayerSkin();
    }

    public void SetPlayerYellowFrog()
    {
        PlayerPrefs.SetString("PlayerSelected", "YellowFrog");
        ResetPlayerSkin();
    }

    public void SetPlayerGrayFrog()
    {
        PlayerPrefs.SetString("PlayerSelected", "GrayFrog");
        ResetPlayerSkin();
    }

    public void SetPlayerMaskDude()
    {
        PlayerPrefs.SetString("PlayerSelected", "MaskDude");
        ResetPlayerSkin();
    }

    public void SetPlayerMaskDudeGreen()
    {
        PlayerPrefs.SetString("PlayerSelected", "GreenMaskDude");
        ResetPlayerSkin();
    }

    public void SetPlayerMaskDudePurple()
    {
        PlayerPrefs.SetString("PlayerSelected", "PurpleMaskDude");
        ResetPlayerSkin();
    }

    public void SetPlayerMaskDudeRed()
    {
        PlayerPrefs.SetString("PlayerSelected", "RedMaskDude");
        ResetPlayerSkin();
    }

    public void SetPlayerMaskDudeGray()
    {
        PlayerPrefs.SetString("PlayerSelected", "GrayMaskDude");
        ResetPlayerSkin();
    }

    public void SetPlayerPinkMan()
    {
        PlayerPrefs.SetString("PlayerSelected", "PinkMan");
        ResetPlayerSkin();
    }

    public void SetPlayerVirtualGuy()
    {
        PlayerPrefs.SetString("PlayerSelected", "VirtualGuy");
        ResetPlayerSkin();
    }

    public void SetPlayerGreenVirtualGuy()
    {
        PlayerPrefs.SetString("PlayerSelected", "GreenVirtualGuy");
        ResetPlayerSkin();
    }

    void ResetPlayerSkin()
    {
        skinsPanel.gameObject.SetActive(false);
        player.GetComponent<PlayerSelector>().ChangePlayerInMenu();
    }
}
