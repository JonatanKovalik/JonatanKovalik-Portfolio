using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using static NewGameSettingsInvestigator;

public class CoreGameplaySettings : MonoBehaviour
{
    public Dropdown dropdown;
    public GameObject panel;
    private bool check = false;
    private void Update()
    {
        if (stage == 3 && check == false)
        {
            panel.SetActive(true);
            check = true;
        }
        if(stage != 3)
        {
            panel.SetActive(false);
        }
    }

    private void Start()
    {
        panel.SetActive(false);
    }

    public void buttonnexttoVisualtageclick()
    {
        if (stage == 3)
        {
            try
            {
                string Gamemodedropdownvaluetext = dropdown.options[dropdown.value].text;
                PlayerPrefs.SetString("PsychologicalTrauma", Gamemodedropdownvaluetext);
            }
            catch
            {
                Debug.LogError("Error saving data in second stage");
            }
            stage = 4;
            Debug.Log("Stage: " + stage);
        }
    }
}
