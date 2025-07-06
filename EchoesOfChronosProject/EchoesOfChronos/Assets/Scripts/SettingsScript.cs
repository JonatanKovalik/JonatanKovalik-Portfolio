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
    public Button BackButton;

    public GameObject model_human;
    public PlayableDirector cameradir;
    public PlayableDirector cameradir2;
    public PlayableDirector cameradir3;
    public PlayableDirector cameradir4;

    public PlayableDirector cameradirback;
    public PlayableDirector cameradirback2;
    public PlayableDirector cameradirback3;
    public PlayableDirector cameradirback4;
    public Text Title;

    private RectTransform audioButtonRectTransform;
    private RectTransform graphicsButtonRectTransform;
    private RectTransform controlsButtonRectTransform;
    private RectTransform gamePlayButtonRectTransform;
    private RectTransform titleRectTransform;

    private float defaultXPosition = -527f;
    private float initialTitleXPosition = -468f;
    private float targetXPosition = -2183f;

    private float animationDuration = 1.3f;
    private float positionTolerance = 5f;

    private bool isAnimatingUIElements = false;
    private bool isTitleAnimatingBack = false;

    private string currentButtonClicked = "";

    public GameObject AudioPanel;
    public GameObject GraphicsPanel;
    public GameObject ControlsPanel;
    public GameObject GamePlayPanel;

    void Start()
    {
        BackButton.gameObject.SetActive(false);
        AudioPanel.SetActive(false);
        GraphicsPanel.SetActive(false);
        ControlsPanel.SetActive(false);
        GamePlayPanel.SetActive(false);
        audioButtonRectTransform = AudioButton.GetComponent<RectTransform>();
        graphicsButtonRectTransform = GraphicsButton.GetComponent<RectTransform>();
        controlsButtonRectTransform = ControlsButton.GetComponent<RectTransform>();
        gamePlayButtonRectTransform = GamePlayButton.GetComponent<RectTransform>();
        titleRectTransform = Title.GetComponent<RectTransform>();

        Title.gameObject.SetActive(true);
        AudioButton.gameObject.SetActive(true);
        GraphicsButton.gameObject.SetActive(true);
        ControlsButton.gameObject.SetActive(true);
        GamePlayButton.gameObject.SetActive(true);

        model_human.SetActive(true);
        model_human.transform.position = new Vector3(-9.83f, 1.31f, 8.94f);

        audioButtonRectTransform.anchoredPosition = new Vector2(defaultXPosition, audioButtonRectTransform.anchoredPosition.y);
        graphicsButtonRectTransform.anchoredPosition = new Vector2(defaultXPosition, graphicsButtonRectTransform.anchoredPosition.y);
        controlsButtonRectTransform.anchoredPosition = new Vector2(defaultXPosition, controlsButtonRectTransform.anchoredPosition.y);
        gamePlayButtonRectTransform.anchoredPosition = new Vector2(defaultXPosition, gamePlayButtonRectTransform.anchoredPosition.y);

        titleRectTransform.anchoredPosition = new Vector2(initialTitleXPosition, titleRectTransform.anchoredPosition.y);

        StartCoroutine(InitialAnimationSequence());
    }

    IEnumerator InitialAnimationSequence()
    {
        SetButtonsInteractable(false);
        if (cameradir != null)
        {
            cameradir.Play();
            while (cameradir.state == PlayState.Playing)
            {
                yield return null;
            }
        }
        SetButtonsInteractable(true);
    }

    private void SetButtonsInteractable(bool interactable)
    {
        AudioButton.interactable = interactable;
        GraphicsButton.interactable = interactable;
        ControlsButton.interactable = interactable;
        GamePlayButton.interactable = interactable;
    }

    IEnumerator HandleButtonClickSequence(PlayableDirector categoryCameraDirector)
    {
        if (isAnimatingUIElements)
        {
            yield break;
        }

        isAnimatingUIElements = true;
        SetButtonsInteractable(false);

        List<RectTransform> elementsToAnimate = new List<RectTransform>()
        {
            audioButtonRectTransform,
            graphicsButtonRectTransform,
            controlsButtonRectTransform,
            gamePlayButtonRectTransform,
            titleRectTransform
        };

        foreach (RectTransform rectT in elementsToAnimate)
        {
            StartCoroutine(AnimateSingleRectTransformToTarget(rectT));
        }

        yield return new WaitForSeconds(animationDuration);

        if (cameradirback != null)
        {
            cameradirback.Play();
            while (cameradirback.state == PlayState.Playing)
            {
                yield return null;
            }
        }

        if (categoryCameraDirector != null)
        {
            categoryCameraDirector.Play();
        }

        isAnimatingUIElements = false;

        switch (currentButtonClicked)
        {
            case "Audio":
                Title.text = "Audio Settings";
                AudioPanel.SetActive(true);
                break;
            case "Graphics":
                Title.text = "Graphics Settings";
                GraphicsPanel.SetActive(true);
                break;
            case "Controls":
                Title.text = "Controls Settings";
                ControlsPanel.SetActive(true);
                break;
            case "GamePlay":
                Title.text = "Gameplay Settings";
                GamePlayPanel.SetActive(true);
                break;
        }
        BackButton.gameObject.SetActive(true);
        yield return StartCoroutine(AnimateSingleRectTransformToOriginal(titleRectTransform));

        SetButtonsInteractable(true);
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

    IEnumerator AnimateSingleRectTransformToOriginal(RectTransform rectTransform)
    {
        Vector2 startPos = rectTransform.anchoredPosition;
        Vector2 targetPos = new Vector2(defaultXPosition, startPos.y);

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

    public void BackButtonClick()
    {
        if (!isTitleAnimatingBack)
        {
            StartCoroutine(HandleBackButtonProcess());
        }
    }

    private IEnumerator HandleBackButtonProcess()
    {
        isTitleAnimatingBack = true;
        SetButtonsInteractable(false);

        AudioPanel.SetActive(false);
        GraphicsPanel.SetActive(false);
        ControlsPanel.SetActive(false);
        GamePlayPanel.SetActive(false);
        BackButton.gameObject.SetActive(false);

        PlayableDirector cameraBackSpecificDirector = null;
        switch (currentButtonClicked)
        {
            case "Audio":
                cameraBackSpecificDirector = cameradirback2;
                break;
            case "Graphics":
                cameraBackSpecificDirector = cameradirback3;
                break;
            case "Controls":
                cameraBackSpecificDirector = cameradirback4;
                break;
            case "GamePlay":
                cameraBackSpecificDirector = cameradirback;
                break;
        }

        if (cameraBackSpecificDirector != null)
        {
            cameraBackSpecificDirector.Play();
            while (cameraBackSpecificDirector.state == PlayState.Playing)
            {
                yield return null;
            }
        }

        yield return StartCoroutine(AnimateSingleRectTransformToOriginal(titleRectTransform));

        List<RectTransform> elementsToAnimateBack = new List<RectTransform>()
        {
            audioButtonRectTransform,
            graphicsButtonRectTransform,
            controlsButtonRectTransform,
            gamePlayButtonRectTransform
        };

        foreach (RectTransform rectT in elementsToAnimateBack)
        {
            StartCoroutine(AnimateSingleRectTransformToOriginal(rectT));
        }

        yield return new WaitForSeconds(0.5f);

        cameradir.Play();
        Title.text = "Settings";
        currentButtonClicked = "";

        if (cameradir != null)
        {
            while (cameradir.state == PlayState.Playing)
            {
                yield return null;
            }
        }

        isTitleAnimatingBack = false;
        SetButtonsInteractable(true);
    }

    public void AudioButtonClick()
    {
        if (!isTitleAnimatingBack)
        {
            currentButtonClicked = "Audio";
            StartCoroutine(HandleButtonClickSequence(cameradir2));
        }
    }

    public void GraphicsButtonClick()
    {
        if (!isTitleAnimatingBack)
        {
            currentButtonClicked = "Graphics";
            StartCoroutine(HandleButtonClickSequence(cameradir3));
        }
    }

    public void ControlsButtonClick()
    {
        if (!isTitleAnimatingBack)
        {
            currentButtonClicked = "Controls";
            StartCoroutine(HandleButtonClickSequence(cameradir4));
        }
    }

    public void GamePlayButtonClick()
    {
        if (!isTitleAnimatingBack)
        {
            currentButtonClicked = "GamePlay";
            StartCoroutine(HandleButtonClickSequence(cameradir));
        }
    }

    public void Update()
    {

    }
}