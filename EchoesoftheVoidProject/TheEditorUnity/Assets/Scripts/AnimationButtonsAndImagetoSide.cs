using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class AnimationButtonsAndImagetoSide : MonoBehaviour
{
    public Button startnewgame;
    public Button loadgame;
    public Button options;
    public Button exitgame;
    public GameObject blackpanel;
    public RawImage logo;
    public Canvas canvas;
    public GameObject panel;
    private bool check;


    public static bool options2 = false;

    private void Update()
    {
        if (ButtonFunction.movebuttonandimage == true && check == false)
        {
            StartCoroutine(animations());
            Debug.Log("Animation started"); 
            check = true;
        }
    }

    private void Start()
    {
        canvas.enabled = false;
        check = false;
        panel.SetActive(false);
    }

    public IEnumerator animations()
    {
        float targetX = -1230f;
        float duration = 0.3f;
        float elapsedTime = 0f;

        Vector2 startPosLogo = logo.rectTransform.anchoredPosition;
        Vector2 startPosNewGame = startnewgame.GetComponent<RectTransform>().anchoredPosition;
        Vector2 startPosLoadGame = loadgame.GetComponent<RectTransform>().anchoredPosition;
        Vector2 startPosOptions = options.GetComponent<RectTransform>().anchoredPosition;
        Vector2 startPosExitGame = exitgame.GetComponent<RectTransform>().anchoredPosition;

        Vector2 endPosLogo = new Vector2(targetX, startPosLogo.y);
        Vector2 endPosNewGame = new Vector2(targetX, startPosNewGame.y);
        Vector2 endPosLoadGame = new Vector2(targetX, startPosLoadGame.y);
        Vector2 endPosOptions = new Vector2(targetX, startPosOptions.y);
        Vector2 endPosExitGame = new Vector2(targetX, startPosExitGame.y);

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float t = Mathf.Clamp01(elapsedTime / duration);

            logo.rectTransform.anchoredPosition = Vector2.Lerp(startPosLogo, endPosLogo, t);
            startnewgame.GetComponent<RectTransform>().anchoredPosition = Vector2.Lerp(startPosNewGame, endPosNewGame, t);
            loadgame.GetComponent<RectTransform>().anchoredPosition = Vector2.Lerp(startPosLoadGame, endPosLoadGame, t);
            options.GetComponent<RectTransform>().anchoredPosition = Vector2.Lerp(startPosOptions, endPosOptions, t);
            exitgame.GetComponent<RectTransform>().anchoredPosition = Vector2.Lerp(startPosExitGame, endPosExitGame, t);

            yield return null;
        }

        logo.rectTransform.anchoredPosition = endPosLogo;
        startnewgame.GetComponent<RectTransform>().anchoredPosition = endPosNewGame;
        loadgame.GetComponent<RectTransform>().anchoredPosition = endPosLoadGame;
        options.GetComponent<RectTransform>().anchoredPosition = endPosOptions;
        exitgame.GetComponent<RectTransform>().anchoredPosition = endPosExitGame;
        canvas.enabled = true;
        panel.SetActive(true);
        options2 = true;
        Debug.Log("Animation completed");
        options2 = true;
        OptionsAnimationLine.check2 = false;
    }

    public void exitpanel()
    {
        panel.SetActive(false);
        startnewgame.GetComponent<RectTransform>().anchoredPosition = new Vector2(-555, 70.74841f);
        loadgame.GetComponent<RectTransform>().anchoredPosition = new Vector2(-555, -45.75895f);
        options.GetComponent<RectTransform>().anchoredPosition = new Vector2(-555, -158.5871f);
        exitgame.GetComponent<RectTransform>().anchoredPosition = new Vector2(-555, -280);
        logo.rectTransform.anchoredPosition = new Vector2(-555, 276.2949f);
        check = false;
        ButtonFunction.movebuttonandimage = false;
        blackpanel.GetComponent<Image>().color = new Color32(70, 70, 70, 255);
    }
}
