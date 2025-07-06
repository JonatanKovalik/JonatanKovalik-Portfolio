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
    public PlayableDirector cameradir2;
    public PlayableDirector cameradir3;
    public PlayableDirector cameradir4;
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

    void Start()
    {
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

        SetButtonsInteractable(true);
    }

    private void SetButtonsInteractable(bool interactable)
    {
        AudioButton.interactable = interactable;
        GraphicsButton.interactable = interactable;
        ControlsButton.interactable = interactable;
        GamePlayButton.interactable = interactable;
    }

    IEnumerator HandleButtonClickSequence(PlayableDirector nextCameraDirector)
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

        if (cameradir != null)
        {
            cameradir.Play();
        }

        yield return new WaitForSeconds(animationDuration);

        if (cameradir != null)
        {
            while (cameradir.state == PlayState.Playing)
            {
                yield return null;
            }
        }

        isAnimatingUIElements = false;
        yield return StartCoroutine(UpdateTitleAndAnimateBack());

        if (nextCameraDirector != null)
        {
            nextCameraDirector.Play();
        }

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

    IEnumerator AnimateSingleRectTransformToTargetTextAudio(RectTransform rectTransform)
    {
        isTitleAnimatingBack = true;
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
        isTitleAnimatingBack = false;
    }

    IEnumerator UpdateTitleAndAnimateBack()
    {
        while (Mathf.Abs(titleRectTransform.anchoredPosition.x - targetXPosition) > positionTolerance)
        {
            yield return null;
        }

        switch (currentButtonClicked)
        {
            case "Audio":
                Title.text = "Audio Settings";
                break;
            case "Graphics":
                Title.text = "Graphics Settings";
                break;
            case "Controls":
                Title.text = "Controls Settings";
                break;
            case "GamePlay":
                Title.text = "Gameplay Settings";
                break;
        }

        yield return StartCoroutine(AnimateSingleRectTransformToTargetTextAudio(titleRectTransform));
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
        // This method is now empty as the logic has been moved to coroutines.
    }
}