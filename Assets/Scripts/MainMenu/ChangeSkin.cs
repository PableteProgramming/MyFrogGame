using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkin : MonoBehaviour
{
    public GameObject player;

    public void ResetPlayerSkin()
    {
        SaveLoad.Save();
        Time.timeScale = 1;
        gameObject.SetActive(false);
        player.GetComponent<PlayerSelector>().ChangePlayerInMenu();
    }

    public void SetPlayerFrog()
    {
        SaveLoad.Game.skin = "Frog";
        //PlayerPrefs.SetString("PlayerSelected", "Frog");
        ResetPlayerSkin();
    }

    public void SetPlayerBlueFrog()
    {
        SaveLoad.Game.skin = "BlueFrog";
        //PlayerPrefs.SetString("PlayerSelected", "BlueFrog");
        ResetPlayerSkin();
    }

    public void SetPlayerOrangeFrog()
    {
        SaveLoad.Game.skin = "OrangeFrog";
        //PlayerPrefs.SetString("PlayerSelected", "OrangeFrog");
        ResetPlayerSkin();
    }

    public void SetPlayerYellowFrog()
    {
        SaveLoad.Game.skin = "YellowFrog";
        //PlayerPrefs.SetString("PlayerSelected", "YellowFrog");
        ResetPlayerSkin();
    }

    public void SetPlayerGrayFrog()
    {
        SaveLoad.Game.skin = "GrayFrog";
        //PlayerPrefs.SetString("PlayerSelected", "GrayFrog");
        ResetPlayerSkin();
    }

    public void SetPlayerMaskDude()
    {
        SaveLoad.Game.skin = "MaskDude";
        //PlayerPrefs.SetString("PlayerSelected", "MaskDude");
        ResetPlayerSkin();
    }

    public void SetPlayerMaskDudeGreen()
    {
        SaveLoad.Game.skin = "GreenMaskDude";
        //PlayerPrefs.SetString("PlayerSelected", "GreenMaskDude");
        ResetPlayerSkin();
    }

    public void SetPlayerMaskDudePurple()
    {
        SaveLoad.Game.skin = "PurpleMaskDude";
        //PlayerPrefs.SetString("PlayerSelected", "PurpleMaskDude");
        ResetPlayerSkin();
    }

    public void SetPlayerMaskDudeRed()
    {
        SaveLoad.Game.skin = "RedMaskDude";
        //PlayerPrefs.SetString("PlayerSelected", "RedMaskDude");
        ResetPlayerSkin();
    }

    public void SetPlayerMaskDudeGray()
    {
        SaveLoad.Game.skin = "GrayMaskDude";
        //PlayerPrefs.SetString("PlayerSelected", "GrayMaskDude");
        ResetPlayerSkin();
    }

    public void SetPlayerPinkMan()
    {
        SaveLoad.Game.skin = "PinkMan";
        //PlayerPrefs.SetString("PlayerSelected", "PinkMan");
        ResetPlayerSkin();
    }

    public void SetPlayerVirtualGuy()
    {
        SaveLoad.Game.skin = "VirtualGuy";
        //PlayerPrefs.SetString("PlayerSelected", "VirtualGuy");
        ResetPlayerSkin();
    }

    public void SetPlayerGreenVirtualGuy()
    {
        SaveLoad.Game.skin = "GreenVirtualGuy";
        //PlayerPrefs.SetString("PlayerSelected", "GreenVirtualGuy");
        ResetPlayerSkin();
    }

    public void SetPlayerPurpleVirtualGuy()
    {
        SaveLoad.Game.skin = "PurpleVirtualGuy";
        //PlayerPrefs.SetString("PlayerSelected", "PurpleVirtualGuy");
        ResetPlayerSkin();
    }
}
