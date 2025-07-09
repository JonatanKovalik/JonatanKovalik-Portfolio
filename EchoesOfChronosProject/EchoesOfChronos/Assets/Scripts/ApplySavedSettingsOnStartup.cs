using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class ApplySavedSettingsOnStartup : MonoBehaviour
{
    void Awake()
    {
        LoadAndApplyGraphicsSettings();
    }

    void LoadAndApplyGraphicsSettings()
    {
        int savedResolutionIndex = PlayerPrefs.GetInt("ResolutionIndex", 1);
        int desiredWidth = Screen.width;
        int desiredHeight = Screen.height;
        switch (savedResolutionIndex)
        {
            case 0: desiredWidth = 2560; desiredHeight = 1440; break;
            case 1: desiredWidth = 1920; desiredHeight = 1080; break;
            case 2: desiredWidth = 1280; desiredHeight = 720; break;
            case 3: desiredWidth = 800; desiredHeight = 600; break;
            case 4: desiredWidth = 640; desiredHeight = 480; break;
        }

        int savedDisplayModeIndex = PlayerPrefs.GetInt("DisplayModeIndex", 0);
        FullScreenMode loadedFullScreenMode = FullScreenMode.ExclusiveFullScreen;
        switch (savedDisplayModeIndex)
        {
            case 0: loadedFullScreenMode = FullScreenMode.ExclusiveFullScreen; break;
            case 1: loadedFullScreenMode = FullScreenMode.FullScreenWindow; break;
            case 2: loadedFullScreenMode = FullScreenMode.Windowed; break;
        }

        int savedRefreshRateIndex = PlayerPrefs.GetInt("RefreshRateIndex", 2);
        int rawSelectedRefreshRate = 0;
        switch (savedRefreshRateIndex)
        {
            case 0: rawSelectedRefreshRate = 144; break;
            case 1: rawSelectedRefreshRate = 120; break;
            case 2: rawSelectedRefreshRate = 60; break;
        }
        RefreshRate customRefreshRate = new RefreshRate
        {
            numerator = (uint)rawSelectedRefreshRate,
            denominator = 1
        };

        Screen.SetResolution(desiredWidth, desiredHeight, loadedFullScreenMode, customRefreshRate);
        Debug.Log($"Applied startup resolution: {desiredWidth}x{desiredHeight}, Mode: {loadedFullScreenMode}, Refresh: {rawSelectedRefreshRate}Hz");

        int savedVSyncEnabled = PlayerPrefs.GetInt("VSyncEnabled", 1);
        QualitySettings.vSyncCount = savedVSyncEnabled;
        Debug.Log($"Applied startup VSync: {(savedVSyncEnabled == 1 ? "Enabled" : "Disabled")}");

        int savedQualityPresetIndex = PlayerPrefs.GetInt("QualityPresetIndex", 1);
        int qualityLevelToSet = 0;
        switch (savedQualityPresetIndex)
        {
            case 0: qualityLevelToSet = 6; break;
            case 1: qualityLevelToSet = 5; break;
            case 2: qualityLevelToSet = 2; break;
            case 3: qualityLevelToSet = 0; break;
        }
        QualitySettings.SetQualityLevel(qualityLevelToSet);
        Debug.Log($"Applied startup Quality Preset: {QualitySettings.names[QualitySettings.GetQualityLevel()]}");

        float savedFOV = PlayerPrefs.GetFloat("FOV", 90f);
        if (Camera.main != null)
        {
            Camera.main.fieldOfView = savedFOV;
            Debug.Log("Applied startup FOV: " + savedFOV);
        }
        else
        {
            Debug.LogWarning("No main camera found to apply startup FOV.");
        }
    }
}