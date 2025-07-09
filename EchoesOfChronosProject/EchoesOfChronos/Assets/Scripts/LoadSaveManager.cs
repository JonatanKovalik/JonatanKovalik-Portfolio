using UnityEngine;

public class LoadSaveManager : MonoBehaviour
{
    public static LoadSaveManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SaveGraphicsSettings(
        float fov,
        bool vsyncEnabled,
        int resolutionIndex,
        int displayModeIndex,
        int refreshRateIndex,
        int qualityPresetIndex)
    {
        PlayerPrefs.SetFloat("FOV", fov);

        int vsyncIntValue = 0;
        if (vsyncEnabled)
        {
            vsyncIntValue = 1;
        }
        PlayerPrefs.SetInt("VSyncEnabled", vsyncIntValue);

        PlayerPrefs.SetInt("ResolutionIndex", resolutionIndex);
        PlayerPrefs.SetInt("DisplayModeIndex", displayModeIndex);
        PlayerPrefs.SetInt("RefreshRateIndex", refreshRateIndex);
        PlayerPrefs.SetInt("QualityPresetIndex", qualityPresetIndex);

        PlayerPrefs.Save();
        Debug.Log("Graphics settings saved by LoadSaveManager.");
    }

    public GraphicsSettingsData LoadGraphicsSettings()
    {
        GraphicsSettingsData settings = new GraphicsSettingsData();

        settings.fov = PlayerPrefs.GetFloat("FOV", 90f);

        int vsyncIntValue = PlayerPrefs.GetInt("VSyncEnabled", 1);
        if (vsyncIntValue == 1)
        {
            settings.vsyncEnabled = true;
        }
        else
        {
            settings.vsyncEnabled = false;
        }

        settings.resolutionIndex = PlayerPrefs.GetInt("ResolutionIndex", 1);
        settings.displayModeIndex = PlayerPrefs.GetInt("DisplayModeIndex", 0);
        settings.refreshRateIndex = PlayerPrefs.GetInt("RefreshRateIndex", 2);
        settings.qualityPresetIndex = PlayerPrefs.GetInt("QualityPresetIndex", 1);

        Debug.Log("Graphics settings loaded by LoadSaveManager.");
        return settings;
    }

    public void ResetAllPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
        Debug.Log("All PlayerPrefs have been reset.");
    }
}

public class GraphicsSettingsData
{
    public float fov;
    public bool vsyncEnabled;
    public int resolutionIndex;
    public int displayModeIndex;
    public int refreshRateIndex;
    public int qualityPresetIndex;
}