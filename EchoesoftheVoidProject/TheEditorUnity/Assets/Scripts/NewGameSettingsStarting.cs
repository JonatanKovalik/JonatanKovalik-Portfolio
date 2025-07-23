using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static NewGameSettingsInvestigator;

public class NewGameSettingsStarting : MonoBehaviour
{
    public GameObject panel;
    public Dropdown psychologicaltrauma;
    public Button Jumpscares;
    public Button Distortion;
    public Dropdown Critical;
    private bool distortion = false;
    private bool jumpscares = false;
    private bool stagecheck = false;
    public GameObject next;

    private void Update()
    {
        if(stage == 2 && !stagecheck)
        {
            panel.SetActive(true);
            stagecheck = true;
        }
        if(stage != 2)
        {
            panel.SetActive(false);
        }
    }
    private void Start()
    {
        panel.SetActive(false);
        next.SetActive(false);
        StartCoroutine(wait());
    }

    private IEnumerator wait()
    {
        yield return new WaitForSeconds(0.4f);
        next.SetActive(true);
    }

    public void buttonnexttoCorestageclick()
    {
        if(stage == 2)
        {
            try
            {
                PlayerPrefs.SetString("JumpscaresButtonOnOff", Jumpscares.GetComponentInChildren<Text>().text);
                PlayerPrefs.SetString("distortionButtonOnOff", Distortion.GetComponentInChildren<Text>().text);
                string psychologicaltraumaTextValue = psychologicaltrauma.options[psychologicaltrauma.value].text;
                PlayerPrefs.SetString("PsychologicalTrauma", psychologicaltraumaTextValue);
                string criticalTextValue = Critical.options[Critical.value].text;
                PlayerPrefs.SetString("Critical", criticalTextValue);
            }
            catch
            {
                Debug.LogError("Error saving data in second stage");
            }
            stage = 3;
            Debug.Log("Stage: " + stage);
        }
    }

    public void buttonclickjumpscares()
    {
        if (jumpscares)
        {
            Jumpscares.GetComponentInChildren<Text>().text = "Enable";
            Jumpscares.GetComponent<Image>().color = new Color32(142,245,142,255);
            jumpscares = false;
        }
        else if(!jumpscares)
        {
            Jumpscares.GetComponentInChildren<Text>().text = "Disable";
            Jumpscares.GetComponent<Image>().color = new Color32(245, 142, 142, 255);
            jumpscares = true;
        }
    }
    
    public void buttonclickdistortion()
    {
        if (distortion)
        {
            Distortion.GetComponentInChildren<Text>().text = "Enable";
            Distortion.GetComponent<Image>().color = new Color32(142, 245, 142, 255);
            distortion = false;
        }
        else if(!distortion)
        {
            Distortion.GetComponentInChildren<Text>().text = "Disable";
            Distortion.GetComponent<Image>().color = new Color32(245, 142, 142, 255);
            distortion = true;
        }
    }

}
