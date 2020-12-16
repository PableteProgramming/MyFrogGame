using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelector : MonoBehaviour
{
    //public bool enableSelectCharacter;
    public enum Player { Frog, VirtualGuy, PinkMan, MaskDude };
    public Player playerSelected;
    public Animator animator;
    public SpriteRenderer SpriteRenderer;

    public RuntimeAnimatorController[] playersController;
    public Sprite[] playersRenderer;

    void Start()
    {
        /*if (!enableSelectCharacter)
        {
            ChangePlayerInMenu();
        }
        else
        {*/
            switch (playerSelected)
            {
                case Player.Frog:
                    SpriteRenderer.sprite = playersRenderer[0];
                    animator.runtimeAnimatorController = playersController[0];
                    break;
                case Player.VirtualGuy:
                    SpriteRenderer.sprite = playersRenderer[2];
                    animator.runtimeAnimatorController = playersController[2];
                    break;
                case Player.PinkMan:
                    SpriteRenderer.sprite = playersRenderer[1];
                    animator.runtimeAnimatorController = playersController[1];
                    break;
                case Player.MaskDude:
                    SpriteRenderer.sprite = playersRenderer[3];
                    animator.runtimeAnimatorController = playersController[3];
                    break;
                default:
                    break;
            }
        //}

    }

    public void ChangePlayerInMenu()
    {
        switch (PlayerPrefs.GetString("PlayerSelected"))
        {
            case "Frog":
                SpriteRenderer.sprite = playersRenderer[0];
                animator.runtimeAnimatorController = playersController[0];
                break;
            case "VirtualGuy":
                SpriteRenderer.sprite = playersRenderer[2];
                animator.runtimeAnimatorController = playersController[2];
                break;
            case "PinkMan":
                SpriteRenderer.sprite = playersRenderer[1];
                animator.runtimeAnimatorController = playersController[1];
                break;
            case "MaskDude":
                SpriteRenderer.sprite = playersRenderer[3];
                animator.runtimeAnimatorController = playersController[3];
                break;
            default:
                break;
        }
    }
}
