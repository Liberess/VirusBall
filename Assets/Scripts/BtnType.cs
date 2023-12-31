﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public enum BTNType
{
    New,
    Load,
    Save,
    Option,
    Back,
    Main,
    Exit,
    Restart,
    Stage
}

public class BtnType : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public BTNType currentType;

    //public Transform buttonScale;

    public CanvasGroup mainGroup;
    public CanvasGroup optionGroup;

    //Vector3 defaultScale;

    private void Start()
    {
        //defaultScale = buttonScale.localScale;
    }

    public void OnBtnClick()
    {
        SoundManager.Instance.PlaySFX("UIClick");

        switch (currentType)
        {
            case BTNType.New:
                //SceneLoad.LoadSceneHandle(3, 1);
                Time.timeScale = 1f;
                SceneManager.LoadScene("Level_1");
                break;
            case BTNType.Load:
                //gameManager.GameLoad();
                break;
            case BTNType.Save:
                //gameManager.GameSave();
                break;
            case BTNType.Option:
                CanvasGroupOn(optionGroup);
                CanvasGroupOff(mainGroup);
                break;
            case BTNType.Back:
                CanvasGroupOn(mainGroup);
                CanvasGroupOff(optionGroup);
                break;
            case BTNType.Main:
                //SceneLoad.LoadSceneHandle(1, 0);
                Time.timeScale = 1f;
                SceneManager.LoadScene("Main");
                break;
            case BTNType.Exit:
                GameManager.Instance.GameQuit();
                break;
            case BTNType.Restart:
                Time.timeScale = 1f;
                GameManager.Instance.GameRetry();
                break;
            case BTNType.Stage:
                //SceneLoad.LoadSceneHandle(1, 0);
                Time.timeScale = 1f;
                SceneManager.LoadScene("Stage");
                break;
        }
    }

    public void CanvasGroupOn(CanvasGroup cg)
    {
        cg.alpha = 1;
        cg.interactable = true;
        cg.blocksRaycasts = true;
    }

    public void CanvasGroupOff(CanvasGroup cg)
    {
        cg.alpha = 0;
        cg.interactable = false;
        cg.blocksRaycasts = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //buttonScale.localScale = defaultScale * 1.2f;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //buttonScale.localScale = defaultScale;
    }
}