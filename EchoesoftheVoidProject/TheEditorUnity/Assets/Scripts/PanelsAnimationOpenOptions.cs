using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static OptionsAnimationLine;

public class PanelsAnimationOpenOptions : MonoBehaviour
{
    public GameObject displaypanel;
    public GameObject audiopanel;
    public GameObject controlpanel;
    public GameObject accessibilitypanel;
    public GameObject blackpanel;

    private void Update()
    {
        if (displaybutton)
        {
            blackpanel.GetComponent<Image>().color = new Color32(70, 70, 70, 255);
            displaypanel.SetActive(true);
            controlpanel.SetActive(false);
            accessibilitypanel.SetActive(false);
            audiopanel.SetActive(false);
            StartCoroutine(OpenPanelAnimation());
            displaybutton = false;
        }
        if (audiobutton)
        {
            blackpanel.GetComponent<Image>().color = new Color32(70, 70, 70, 255);
            audiopanel.SetActive(true);
            displaypanel.SetActive(false);
            controlpanel.SetActive(false);
            accessibilitypanel.SetActive(false);
            StartCoroutine(OpenPanelAnimation());
            audiobutton = false;
        }
        if (controlbutton)
        {
            blackpanel.GetComponent<Image>().color = new Color32(70, 70, 70, 255);
            controlpanel.SetActive(true);
            displaypanel.SetActive(false);
            audiopanel.SetActive(false);
            accessibilitypanel.SetActive(false);
            StartCoroutine(OpenPanelAnimation());
            controlbutton = false;
        }
        if (accessibilitybutton)
        {
            blackpanel.GetComponent<Image>().color = new Color32(70, 70, 70, 255);
            accessibilitypanel.SetActive(true);
            displaypanel.SetActive(false);
            audiopanel.SetActive(false);
            controlpanel.SetActive(false);
            StartCoroutine(OpenPanelAnimation());
            accessibilitybutton = false;
        }
    }

    private void Start()
    {
        blackpanel.SetActive(true);
        blackpanel.GetComponent<Image>().color = new Color32(70, 70, 70, 255);
    }

    private IEnumerator OpenPanelAnimation()
    {
        Image panelImage = blackpanel.GetComponent<Image>();
        Color startColor = panelImage.color;
        Color endColor = new Color(startColor.r, startColor.g, startColor.b, 0f);
        float duration = 0.5f;
        float elapsedTime = 0f;
        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float t = Mathf.Clamp01(elapsedTime / duration);
            panelImage.color = Color.Lerp(startColor, endColor, t);
            yield return null;
        }
        panelImage.color = endColor;
        yield return new WaitForSeconds(0.3f);
    }
}
