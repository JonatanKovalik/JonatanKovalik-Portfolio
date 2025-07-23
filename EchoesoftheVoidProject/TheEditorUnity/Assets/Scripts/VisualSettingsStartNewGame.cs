using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VisualSettingsStartNewGame : MonoBehaviour
{
    public GameObject panel;
    private bool check = false;
    public Dropdown dropdown;
    public Slider Slider;
    public Button Subtitles;
    private bool Subtitlescheck = false;

    private void Update()
    {
        if (NewGameSettingsInvestigator.stage == 4 && !check)
        {
            panel.SetActive(true);
            check = true;
        }
        if (NewGameSettingsInvestigator.stage != 4)
        {
            panel.SetActive(false);
        }
    }

    private void Start()
    {
        panel.SetActive(false);
    }

    public void Subtitlesbuttonclick()
    {
        if (Subtitlescheck)
        {
            Subtitles.GetComponentInChildren<Text>().text = "Enable";
            Subtitles.GetComponent<Image>().color = new Color32(142, 245, 142, 255);
            Subtitlescheck = false;
        }
        else if (!Subtitlescheck)
        {
            Subtitles.GetComponentInChildren<Text>().text = "Disable";
            Subtitles.GetComponent<Image>().color = new Color32(245, 142, 142, 255);
            Subtitlescheck = true;
        }
    }

    public void finishbuttonclick()
    {
        if(NewGameSettingsInvestigator.stage == 4)
        {
            try
            {
                string visualfilterdropdownvaluetext = dropdown.options[dropdown.value].text;
                PlayerPrefs.SetString("VisualFilter", visualfilterdropdownvaluetext);
                PlayerPrefs.SetFloat("ScrollbarValue", Slider.value);
                PlayerPrefs.SetString("SubtitlesButtonOnOff", Subtitles.GetComponentInChildren<Text>().text);
            }
            catch 
            {
                Debug.LogError("Error saving data in visual settings stage");
            }
        }
        Debug.Log("The player finish all new game settings");
        SceneManager.LoadScene("Game");
    }
}
