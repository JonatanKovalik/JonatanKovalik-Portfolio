using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GraphicsSettingsScript : MonoBehaviour
{
    public TMP_Dropdown ResolutionDropDown;
    public TMP_Dropdown DisplayModeDropDown;
    public TMP_Dropdown RefreshRateDropDown;
    public TMP_Dropdown GraphicsQualityPresetDropDown;

    public Button VSyncButton;
    public Scrollbar FieldOfViewScroolBar;

    private float minFOVValue = 60f;
    private float maxFOVValue = 100f;
    private float defaultFOV = 90f;

    private bool vsyncEnabled;
    private FullScreenMode currentFullScreenMode;

    void Start()
    {
        FieldOfViewScroolBar.onValueChanged.AddListener(FieldOfView);
        ResolutionDropDown.onValueChanged.AddListener((index) => ResolutionChanged(index));
        DisplayModeDropDown.onValueChanged.AddListener((index) => OnDisplayModeChanged(index));
        RefreshRateDropDown.onValueChanged.AddListener((index) => RefreshRateChanged(index));
        GraphicsQualityPresetDropDown.onValueChanged.AddListener((index) => graphicsqulaitypresetChanged(index));
        VSyncButton.onClick.AddListener(OnVSyncButtonClicked);

        LoadAllSettingsFromManager();

        ResolutionDropDown.gameObject.SetActive(true);
        DisplayModeDropDown.gameObject.SetActive(true);
        RefreshRateDropDown.gameObject.SetActive(true);
        GraphicsQualityPresetDropDown.gameObject.SetActive(true);
        VSyncButton.gameObject.SetActive(true);
        FieldOfViewScroolBar.gameObject.SetActive(true);
    }

    private void LoadAllSettingsFromManager()
    {
        if (LoadSaveManager.Instance == null)
        {
            Debug.LogError("LoadSaveManager instance not found! Make sure it's in the scene and persistent.");
            return;
        }

        GraphicsSettingsData loadedSettings = LoadSaveManager.Instance.LoadGraphicsSettings();

        float normalizedFOV = Mathf.InverseLerp(minFOVValue, maxFOVValue, loadedSettings.fov);
        FieldOfViewScroolBar.value = normalizedFOV;

        vsyncEnabled = loadedSettings.vsyncEnabled;

        InitializeDisplayModeDropdown();
        DisplayModeDropDown.value = loadedSettings.displayModeIndex;
        DisplayModeDropDown.RefreshShownValue();
        OnDisplayModeChanged(loadedSettings.displayModeIndex);

        InitializeResolutionDropdown();
        ResolutionDropDown.value = loadedSettings.resolutionIndex;
        ResolutionDropDown.RefreshShownValue();

        InitializeRefreshRateDropdown();
        RefreshRateDropDown.value = loadedSettings.refreshRateIndex;
        RefreshRateDropDown.RefreshShownValue();

        InitializeQualityPresetDropdown();
        GraphicsQualityPresetDropDown.value = loadedSettings.qualityPresetIndex;
        GraphicsQualityPresetDropDown.RefreshShownValue();

        ApplyVSyncSetting();
        UpdateVSyncButtonUI();
        FieldOfView(FieldOfViewScroolBar.value);
        graphicsqulaitypresetChanged(GraphicsQualityPresetDropDown.value);
        ApplyCurrentResolutionSettings();
    }

    private void SaveAllSettingsToManager()
    {
        if (LoadSaveManager.Instance == null)
        {
            Debug.LogError("LoadSaveManager instance not found! Settings will not be saved.");
            return;
        }

        float currentFOV = defaultFOV;
        if (Camera.main != null)
        {
            currentFOV = Camera.main.fieldOfView;
        }

        LoadSaveManager.Instance.SaveGraphicsSettings(
            currentFOV,
            vsyncEnabled,
            ResolutionDropDown.value,
            DisplayModeDropDown.value,
            RefreshRateDropDown.value,
            GraphicsQualityPresetDropDown.value
        );
    }

    void InitializeResolutionDropdown()
    {
        ResolutionDropDown.ClearOptions();
        List<string> resolutionOptions = new List<string>
        {
            "2560x1440", "1920x1080", "1280x720", "800x600", "640x480"
        };
        ResolutionDropDown.AddOptions(resolutionOptions);
    }

    void InitializeDisplayModeDropdown()
    {
        DisplayModeDropDown.ClearOptions();
        List<string> displayModeOptions = new List<string> { "Fullscreen", "Borderless Window", "Windowed" };
        DisplayModeDropDown.AddOptions(displayModeOptions);
    }

    void InitializeRefreshRateDropdown()
    {
        RefreshRateDropDown.ClearOptions();
        List<string> refreshRateOptions = new List<string> { "144Hz", "120Hz", "60Hz" };
        RefreshRateDropDown.AddOptions(refreshRateOptions);
    }

    void InitializeQualityPresetDropdown()
    {
        GraphicsQualityPresetDropDown.ClearOptions();
        List<string> qualityOptions = new List<string> { "Ultra", "High", "Medium", "Low" };
        GraphicsQualityPresetDropDown.AddOptions(qualityOptions);
    }

    void UpdateVSyncButtonUI()
    {
        TMP_Text buttonTMPText = VSyncButton.GetComponentInChildren<TMP_Text>();
        if (buttonTMPText != null)
        {
            if (vsyncEnabled)
            {
                buttonTMPText.text = "ON";
                VSyncButton.GetComponent<Image>().color = Color.green;
            }
            else
            {
                buttonTMPText.text = "OFF";
                VSyncButton.GetComponent<Image>().color = Color.red;
            }
        }
        else
        {
            Text buttonLegacyText = VSyncButton.GetComponentInChildren<Text>();
            if (buttonLegacyText != null)
            {
                if (vsyncEnabled)
                {
                    buttonLegacyText.text = "ON";
                    VSyncButton.GetComponent<Image>().color = Color.green;
                }
                else
                {
                    buttonLegacyText.text = "OFF";
                    VSyncButton.GetComponent<Image>().color = Color.red;
                }
            }
            else
            {
                Debug.LogWarning("VSyncButton does not have a Text or TextMeshProUGUI component in its children. VSync UI will not update.");
            }
        }
    }

    void ApplyVSyncSetting()
    {
        if (vsyncEnabled)
        {
            QualitySettings.vSyncCount = 1;
            Debug.Log("VSync Enabled");
        }
        else
        {
            QualitySettings.vSyncCount = 0;
            Debug.Log("VSync Disabled");
        }
    }

    public void OnVSyncButtonClicked()
    {
        vsyncEnabled = !vsyncEnabled;
        ApplyVSyncSetting();
        UpdateVSyncButtonUI();
        SaveAllSettingsToManager();
    }

    public void FieldOfView(float scrollbarValue)
    {
        float actualFOV = Mathf.Lerp(minFOVValue, maxFOVValue, scrollbarValue);

        if (Camera.main != null)
        {
            Camera.main.fieldOfView = actualFOV;
            Debug.Log("Current FOV: " + actualFOV);
        }
        else
        {
            Debug.LogWarning("No main camera found in the scene to set FOV.");
        }
        SaveAllSettingsToManager();
    }

    public void OnDisplayModeChanged(int index)
    {
        if (index == 0)
        {
            currentFullScreenMode = FullScreenMode.ExclusiveFullScreen;
        }
        else if (index == 1)
        {
            currentFullScreenMode = FullScreenMode.FullScreenWindow;
        }
        else if (index == 2)
        {
            currentFullScreenMode = FullScreenMode.Windowed;
        }
        else
        {
            Debug.LogWarning("Unexpected DisplayModeDropDown value: " + index);
            return;
        }
        ApplyCurrentResolutionSettings();
        SaveAllSettingsToManager();
    }

    public void ResolutionChanged(int index)
    {
        int desiredWidth = Screen.width;
        int desiredHeight = Screen.height;

        if (index == 0)
        {
            desiredWidth = 2560;
            desiredHeight = 1440;
        }
        else if (index == 1)
        {
            desiredWidth = 1920;
            desiredHeight = 1080;
        }
        else if (index == 2)
        {
            desiredWidth = 1280;
            desiredHeight = 720;
        }
        else if (index == 3)
        {
            desiredWidth = 800;
            desiredHeight = 600;
        }
        else if (index == 4)
        {
            desiredWidth = 640;
            desiredHeight = 480;
        }
        else
        {
            Debug.LogWarning("Unexpected ResolutionDropDown value: " + index);
        }
        ApplyCurrentResolutionSettings(desiredWidth, desiredHeight);
        SaveAllSettingsToManager();
    }

    public void graphicsqulaitypresetChanged(int index)
    {
        if (index == 0)
        {
            QualitySettings.SetQualityLevel(6);
        }
        else if (index == 1)
        {
            QualitySettings.SetQualityLevel(5);
        }
        else if (index == 2)
        {
            QualitySettings.SetQualityLevel(2);
        }
        else if (index == 3)
        {
            QualitySettings.SetQualityLevel(0);
        }
        else
        {
            Debug.LogWarning("Unexpected GraphicsQualityPresetDropDown value: " + index);
        }
        Debug.Log(QualitySettings.names[QualitySettings.GetQualityLevel()] + " quality preset selected.");
        SaveAllSettingsToManager();
    }

    public void RefreshRateChanged(int index)
    {
        int rawSelectedRefreshRate = 0;

        if (index == 0)
        {
            rawSelectedRefreshRate = 144;
        }
        else if (index == 1)
        {
            rawSelectedRefreshRate = 120;
        }
        else if (index == 2)
        {
            rawSelectedRefreshRate = 60;
        }
        else
        {
            Debug.LogWarning("Unexpected RefreshRateDropDown value: " + index);
            return;
        }

        ApplyCurrentResolutionSettings(Screen.width, Screen.height, rawSelectedRefreshRate);
        Debug.Log("Refresh rate set to: " + rawSelectedRefreshRate + "Hz");
        SaveAllSettingsToManager();
    }

    private void ApplyCurrentResolutionSettings(int width = -1, int height = -1, int refreshRateHz = -1)
    {
        int finalWidth = Screen.width;
        if (width != -1)
        {
            finalWidth = width;
        }

        int finalHeight = Screen.height;
        if (height != -1)
        {
            finalHeight = height;
        }

        int finalRefreshRateHz;
        if (refreshRateHz == -1)
        {
            if (RefreshRateDropDown != null && RefreshRateDropDown.value >= 0 && RefreshRateDropDown.value < RefreshRateDropDown.options.Count)
            {
                if (RefreshRateDropDown.value == 0)
                {
                    finalRefreshRateHz = 144;
                }
                else if (RefreshRateDropDown.value == 1)
                {
                    finalRefreshRateHz = 120;
                }
                else if (RefreshRateDropDown.value == 2)
                {
                    finalRefreshRateHz = 60;
                }
                else
                {
                    finalRefreshRateHz = (int)Screen.currentResolution.refreshRateRatio.numerator;
                }
            }
            else
            {
                finalRefreshRateHz = (int)Screen.currentResolution.refreshRateRatio.numerator;
            }
        }
        else
        {
            finalRefreshRateHz = refreshRateHz;
        }

        RefreshRate customRefreshRate = new RefreshRate
        {
            numerator = (uint)finalRefreshRateHz,
            denominator = 1
        };

        Screen.SetResolution(finalWidth, finalHeight, currentFullScreenMode, customRefreshRate);
    }
}