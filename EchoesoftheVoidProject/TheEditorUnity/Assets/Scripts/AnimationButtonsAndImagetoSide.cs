using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationButtonsAndImagetoSide : MonoBehaviour
{
    public Button startnewgame;
    public Button loadgame;
    public Button options;
    public Button exitgame;
    public RawImage logo;
    private bool check;

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
        check = false;
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
    }
}
