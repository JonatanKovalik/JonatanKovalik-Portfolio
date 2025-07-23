using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static ButtonFunction;
using static System.Net.Mime.MediaTypeNames;

public class NewGameSettingsInvestigator : MonoBehaviour
{
    public GameObject panel;
    public static int stage;
    public InputField inputfield;
    public Dropdown StartingBackground;
    public Dropdown ReasonforArrival;
    private bool startsnewgame = false;
    public GameObject next;


    private void Update()
    {
        if (startnewgame && !startsnewgame)
        {
            stage = 1;
            panel.SetActive(true);
            startsnewgame = true;
        }
        if(stage != 1)
        {
            panel.SetActive(false);
        }
    }

    public void buttonnextfirststageclick()
    {
        if(stage == 1)
        {
            try
            {
                PlayerPrefs.SetString("InvestigatorName", inputfield.text);
                string StartingBackgroundTextValue = StartingBackground.options[StartingBackground.value].text;
                PlayerPrefs.SetString("StartingBackground", StartingBackgroundTextValue);
                string ReasonforArrivalTextValue = ReasonforArrival.options[ReasonforArrival.value].text;
                PlayerPrefs.SetString("ReasonforArrival", ReasonforArrivalTextValue);
                Debug.Log("Data first stage saved");
            }
            catch
            {
                Debug.LogError("Error saving data in first stage");
            }
            next.SetActive(false);
            stage = 2;
            Debug.Log("Stage: " + stage);
        }
    }
    private void Start()
    {
        next.SetActive(true);
    }
}
