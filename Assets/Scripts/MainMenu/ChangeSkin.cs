using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkin : MonoBehaviour
{

    public GameObject player;

    public void ResetPlayerSkin()
    {
        gameObject.SetActive(false);
        player.GetComponent<PlayerSelector>().ChangePlayerInMenu();
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

    public void SetPlayerPurpleVirtualGuy()
    {
        PlayerPrefs.SetString("PlayerSelected", "PurpleVirtualGuy");
        ResetPlayerSkin();
    }
}
