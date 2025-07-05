using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class SettingsScript : MonoBehaviour
{
    public Button AudioButton;
    public Button GraphicsButton;
    public Button ControlsButton;
    public Button GamePlayButton;

    public GameObject model_human;
    public PlayableDirector cameradir;
    public Text Title;

    private float defaultXPosition = -527f;
    private float initialTitleXPosition = -468f;
    private float targetXPosition = -1183f;

    private float animationDuration = 1.3f;

    private bool isAnimatingUIElements = false;

    void Start()
    {
        AudioButton.enabled = true;
        GraphicsButton.enabled = true;
        ControlsButton.enabled = true;
        GamePlayButton.enabled = true;

        AudioButton.gameObject.SetActive(true);
        GraphicsButton.gameObject.SetActive(true);
        ControlsButton.gameObject.SetActive(true);
        GamePlayButton.gameObject.SetActive(true);

        model_human.SetActive(true);
        Title.enabled = true;

        AudioButton.GetComponent<RectTransform>().anchoredPosition = new Vector2(defaultXPosition, AudioButton.GetComponent<RectTransform>().anchoredPosition.y);
        GraphicsButton.GetComponent<RectTransform>().anchoredPosition = new Vector2(defaultXPosition, GraphicsButton.GetComponent<RectTransform>().anchoredPosition.y);
        ControlsButton.GetComponent<RectTransform>().anchoredPosition = new Vector2(defaultXPosition, ControlsButton.GetComponent<RectTransform>().anchoredPosition.y);
        GamePlayButton.GetComponent<RectTransform>().anchoredPosition = new Vector2(defaultXPosition, GamePlayButton.GetComponent<RectTransform>().anchoredPosition.y);

        Title.GetComponent<RectTransform>().anchoredPosition = new Vector2(initialTitleXPosition, Title.GetComponent<RectTransform>().anchoredPosition.y);
    }

    private void HandleAnyButtonClick()
    {
        if (isAnimatingUIElements)
        {
            return;
        }

        StopAllCoroutines();

        StartCoroutine(AnimateAllUIElementsTogether());

        if (cameradir != null)
        {
            cameradir.Play();
        }
    }

    IEnumerator AnimateAllUIElementsTogether()
    {
        isAnimatingUIElements = true;

        List<RectTransform> elementsToAnimate = new List<RectTransform>()
        {
            AudioButton.GetComponent<RectTransform>(),
            GraphicsButton.GetComponent<RectTransform>(),
            ControlsButton.GetComponent<RectTransform>(),
            GamePlayButton.GetComponent<RectTransform>(),
            Title.GetComponent<RectTransform>()
        };

        List<Coroutine> runningAnimations = new List<Coroutine>();

        foreach (RectTransform rectT in elementsToAnimate)
        {
            runningAnimations.Add(StartCoroutine(AnimateSingleRectTransformToTarget(rectT)));
        }

        foreach (Coroutine anim in runningAnimations)
        {
            if (anim != null)
            {
                yield return anim;
            }
        }

        isAnimatingUIElements = false;
    }

    IEnumerator AnimateSingleRectTransformToTarget(RectTransform rectTransform)
    {
        Vector2 startPos = rectTransform.anchoredPosition;
        Vector2 targetPos = new Vector2(targetXPosition, startPos.y);

        float timer = 0f;

        while (timer < animationDuration)
        {
            timer += Time.deltaTime;
            float t = Mathf.SmoothStep(0f, 1f, timer / animationDuration);
            rectTransform.anchoredPosition = Vector2.Lerp(startPos, targetPos, t);
            yield return null;
        }
        rectTransform.anchoredPosition = targetPos;
    }

    public void AudioButtonClick()
    {
        HandleAnyButtonClick();
    }

    public void GraphicsButtonClick()
    {
        HandleAnyButtonClick();
    }

    public void ControlsButtonClick()
    {
        HandleAnyButtonClick();
    }

    public void GamePlayButtonClick()
    {
        HandleAnyButtonClick();
    }
}