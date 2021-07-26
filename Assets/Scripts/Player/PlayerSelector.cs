﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelector : MonoBehaviour
{
    public bool enableSelectCharacter;
    public enum Player { Frog,BlueFrog,GrayFrog,OrangeFrog,YellowFrog, VirtualGuy, GreenVirtualGuy, PurpleVirtualGuy,PinkMan, MaskDude,GreenMaskDude,GrayMaskDude,PurpleMaskDude, RedMaskDude };
    public Player playerSelected;
    public Animator animator;
    public SpriteRenderer SpriteRenderer;

    public RuntimeAnimatorController[] playersController;
    public Sprite[] playersRenderer;

    void Start()
    {
        if (!enableSelectCharacter)
        {
            ChangePlayerInMenu();
        }
        else
        {
            switch (playerSelected)
            {
                case Player.Frog:
                    SpriteRenderer.sprite = playersRenderer[0];
                    animator.runtimeAnimatorController = playersController[0];
                    break;
                case Player.PinkMan:
                    SpriteRenderer.sprite = playersRenderer[1];
                    animator.runtimeAnimatorController = playersController[1];
                    break;
                case Player.VirtualGuy:
                    SpriteRenderer.sprite = playersRenderer[2];
                    animator.runtimeAnimatorController = playersController[2];
                    break;
                case Player.MaskDude:
                    SpriteRenderer.sprite = playersRenderer[3];
                    animator.runtimeAnimatorController = playersController[3];
                    break;
                case Player.GreenMaskDude:
                    SpriteRenderer.sprite = playersRenderer[4];
                    animator.runtimeAnimatorController = playersController[4];
                    break;
                case Player.GrayMaskDude:
                    SpriteRenderer.sprite = playersRenderer[5];
                    animator.runtimeAnimatorController = playersController[5];
                    break;
                case Player.PurpleMaskDude:
                    SpriteRenderer.sprite = playersRenderer[6];
                    animator.runtimeAnimatorController = playersController[6];
                    break;
                case Player.RedMaskDude:
                    SpriteRenderer.sprite = playersRenderer[7];
                    animator.runtimeAnimatorController = playersController[7];
                    break;
                case Player.BlueFrog:
                    SpriteRenderer.sprite = playersRenderer[8];
                    animator.runtimeAnimatorController = playersController[8];
                    break;
                case Player.GrayFrog:
                    SpriteRenderer.sprite = playersRenderer[9];
                    animator.runtimeAnimatorController = playersController[9];
                    break;
                case Player.OrangeFrog:
                    SpriteRenderer.sprite = playersRenderer[10];
                    animator.runtimeAnimatorController = playersController[10];
                    break;
                case Player.YellowFrog:
                    SpriteRenderer.sprite = playersRenderer[11];
                    animator.runtimeAnimatorController = playersController[11];
                    break;
                case Player.GreenVirtualGuy:
                    SpriteRenderer.sprite = playersRenderer[12];
                    animator.runtimeAnimatorController = playersController[12];
                    break;
                case Player.PurpleVirtualGuy:
                    SpriteRenderer.sprite = playersRenderer[13];
                    animator.runtimeAnimatorController = playersController[13];
                    break;
                default:
                    break;
            }
        }

    }

    public void ChangePlayerInMenu()
    {
        SaveLoad.Load();
        switch (SaveLoad.Game.skin)
        {
            case "Frog":
                SpriteRenderer.sprite = playersRenderer[0];
                animator.runtimeAnimatorController = playersController[0];
                break;
            case "PinkMan":
                SpriteRenderer.sprite = playersRenderer[1];
                animator.runtimeAnimatorController = playersController[1];
                break;
            case "VirtualGuy":
                SpriteRenderer.sprite = playersRenderer[2];
                animator.runtimeAnimatorController = playersController[2];
                break;
            case "MaskDude":
                SpriteRenderer.sprite = playersRenderer[3];
                animator.runtimeAnimatorController = playersController[3];
                break;
            case "GreenMaskDude":
                SpriteRenderer.sprite = playersRenderer[4];
                animator.runtimeAnimatorController = playersController[4];
                break;
            case "GrayMaskDude":
                SpriteRenderer.sprite = playersRenderer[5];
                animator.runtimeAnimatorController = playersController[5];
                break;
            case "PurpleMaskDude":
                SpriteRenderer.sprite = playersRenderer[6];
                animator.runtimeAnimatorController = playersController[6];
                break;
            case "RedMaskDude":
                SpriteRenderer.sprite = playersRenderer[7];
                animator.runtimeAnimatorController = playersController[7];
                break;
            case "BlueFrog":
                SpriteRenderer.sprite = playersRenderer[8];
                animator.runtimeAnimatorController = playersController[8];
                break;
            case "GrayFrog":
                SpriteRenderer.sprite = playersRenderer[9];
                animator.runtimeAnimatorController = playersController[9];
                break;
            case "OrangeFrog":
                SpriteRenderer.sprite = playersRenderer[10];
                animator.runtimeAnimatorController = playersController[10];
                break;
            case "YellowFrog":
                SpriteRenderer.sprite = playersRenderer[11];
                animator.runtimeAnimatorController = playersController[11];
                break;
            case "GreenVirtualGuy":
                SpriteRenderer.sprite = playersRenderer[12];
                animator.runtimeAnimatorController = playersController[12];
                break;
            case "PurpleVirtualGuy":
                SpriteRenderer.sprite = playersRenderer[13];
                animator.runtimeAnimatorController = playersController[13];
                break;
            default:
                break;
        }
    }
}
