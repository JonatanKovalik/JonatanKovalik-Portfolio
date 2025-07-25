using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplaySettingsData : MonoBehaviour
{
    public Dropdown resolutiondropdown;
    public Dropdown displaymodedropdown;
    public Dropdown graphicsdropdown;
    public Slider Brightnessslider;
    public Slider fovslider;

    public static bool Resolutionchanged;
    public static int ResolutionIndex;

    public static int GraphicsIndex;
    public static bool GraphicsChanged;

    private void Start()
    {
        resolutiondropdown.value = PlayerPrefs.GetInt("Resulotion", 0);
        displaymodedropdown.value = PlayerPrefs.GetInt("DisplayMode", 0);
        graphicsdropdown.value = PlayerPrefs.GetInt("Graphics", 2);
        Brightnessslider.value = PlayerPrefs.GetFloat("FOV", 90);
        fovslider.value = PlayerPrefs.GetFloat("Brightness", 0.7f);
        Resolutionchanged = false;
    }

    private void Update()
    {
        ResolutionIndex = resolutiondropdown.value;
        GraphicsIndex = graphicsdropdown.value;

    }

    public void Onvluechange() //save
    {
        PlayerPrefs.SetInt("Resulotion", resolutiondropdown.value);
        PlayerPrefs.SetInt("DisplayMode", displaymodedropdown.value);
        PlayerPrefs.SetInt("Graphics", graphicsdropdown.value);
        PlayerPrefs.SetFloat("FOV", fovslider.value);
        PlayerPrefs.SetFloat("Brightness", Brightnessslider.value);
    }

    public void resultionchanged()
    {
        Resolutionchanged = true;
    }

    public void GraphicsChangedfun()
    {
        GraphicsChanged = true;
    }

    public void buttonclickcusomsettings()
    {
        QualitySettings.SetQualityLevel(6, true);
        PlayerPrefs.SetInt("Graphics", 6);
        graphicsdropdown.value = 0;
    }
}
