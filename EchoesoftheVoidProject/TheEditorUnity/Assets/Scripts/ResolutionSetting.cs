using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static DisplaySettingsData;

public class ResolutionSetting : MonoBehaviour
{

    string[] resolutions = {"1920 x 1080", "3840x2160", "2560x1440", "1600x900", "1366x768","1280x960","1280x720","1024x768","2560x1080","3440x1440","800x600","1600x1200","1280x800","1920x1200"};
    private int displayModeIndex;

    private void Update()
    {
        displayModeIndex = PlayerPrefs.GetInt("DisplayMode", 0);
        if (Resolutionchanged == true)
        {
            if(ResolutionIndex == 0)
            {
                if(displayModeIndex == 0)
                    Screen.SetResolution(1920, 1080, FullScreenMode.FullScreenWindow);
                else if(displayModeIndex == 1)
                    Screen.SetResolution(1920, 1080, FullScreenMode.MaximizedWindow);
                else if(displayModeIndex == 2)
                    Screen.SetResolution(1920, 1080, FullScreenMode.Windowed);
            }
            if(ResolutionIndex == 1)
            {
                if (displayModeIndex == 0)
                    Screen.SetResolution(3840, 2160, FullScreenMode.FullScreenWindow);
                else if (displayModeIndex == 1)
                    Screen.SetResolution(3840, 2160, FullScreenMode.MaximizedWindow);
                else if (displayModeIndex == 2)
                    Screen.SetResolution(3840, 2160, FullScreenMode.Windowed);
            }
            if (ResolutionIndex == 2)
            {
                if (displayModeIndex == 0)
                    Screen.SetResolution(2560, 1440, FullScreenMode.FullScreenWindow);
                else if (displayModeIndex == 1)
                    Screen.SetResolution(2560, 1440, FullScreenMode.MaximizedWindow);
                else if (displayModeIndex == 2)
                    Screen.SetResolution(2560, 1440, FullScreenMode.Windowed);
            }
            if (ResolutionIndex == 3)
            {
                if (displayModeIndex == 0)
                    Screen.SetResolution(1600, 900, FullScreenMode.FullScreenWindow);
                else if (displayModeIndex == 1)
                    Screen.SetResolution(1600, 900, FullScreenMode.MaximizedWindow);
                else if (displayModeIndex == 2)
                    Screen.SetResolution(1600, 900, FullScreenMode.Windowed);
            }
            if (ResolutionIndex == 4)
            {
                if (displayModeIndex == 0)
                    Screen.SetResolution(1366, 768, FullScreenMode.FullScreenWindow);
                else if (displayModeIndex == 1)
                    Screen.SetResolution(1366, 768, FullScreenMode.MaximizedWindow);
                else if (displayModeIndex == 2)
                    Screen.SetResolution(1366, 768, FullScreenMode.Windowed);
            }
            if (ResolutionIndex == 5)
            {
                if (displayModeIndex == 0)
                    Screen.SetResolution(1280, 960, FullScreenMode.FullScreenWindow);
                else if (displayModeIndex == 1)
                    Screen.SetResolution(1280, 960, FullScreenMode.MaximizedWindow);
                else if (displayModeIndex == 2)
                    Screen.SetResolution(1280, 960, FullScreenMode.Windowed);
            }
            if (ResolutionIndex == 6)
            {
                if (displayModeIndex == 0)
                    Screen.SetResolution(1280, 720, FullScreenMode.FullScreenWindow);
                else if (displayModeIndex == 1)
                    Screen.SetResolution(1280, 720, FullScreenMode.MaximizedWindow);
                else if (displayModeIndex == 2)
                    Screen.SetResolution(1280, 720, FullScreenMode.Windowed);
            }
            if (ResolutionIndex == 7)
            {
                if (displayModeIndex == 0)
                    Screen.SetResolution(1024, 768, FullScreenMode.FullScreenWindow);
                else if (displayModeIndex == 1)
                    Screen.SetResolution(1024, 768, FullScreenMode.MaximizedWindow);
                else if (displayModeIndex == 2)
                    Screen.SetResolution(1024, 768, FullScreenMode.Windowed);
            }
            if (ResolutionIndex == 8)
            {
                if (displayModeIndex == 0)
                    Screen.SetResolution(2560, 1080, FullScreenMode.FullScreenWindow);
                else if (displayModeIndex == 1)
                    Screen.SetResolution(2560, 1080, FullScreenMode.MaximizedWindow);
                else if (displayModeIndex == 2)
                    Screen.SetResolution(2560, 1080, FullScreenMode.Windowed);
            }
            if (ResolutionIndex == 9)
            {
                if (displayModeIndex == 0)
                    Screen.SetResolution(3440, 1440, FullScreenMode.FullScreenWindow);
                else if (displayModeIndex == 1)
                    Screen.SetResolution(3440, 1440, FullScreenMode.MaximizedWindow);
                else if (displayModeIndex == 2)
                    Screen.SetResolution(3440, 1440, FullScreenMode.Windowed);
            }
            if (ResolutionIndex == 10)
            {
                if (displayModeIndex == 0)
                    Screen.SetResolution(800, 600, FullScreenMode.FullScreenWindow);
                else if (displayModeIndex == 1)
                    Screen.SetResolution(800, 600, FullScreenMode.MaximizedWindow);
                else if (displayModeIndex == 2)
                    Screen.SetResolution(800, 600, FullScreenMode.Windowed);
            }
            if (ResolutionIndex == 11)
            {
                if (displayModeIndex == 0)
                    Screen.SetResolution(1600, 1200, FullScreenMode.FullScreenWindow);
                else if (displayModeIndex == 1)
                    Screen.SetResolution(1600, 1200, FullScreenMode.MaximizedWindow);
                else if (displayModeIndex == 2)
                    Screen.SetResolution(1600, 1200, FullScreenMode.Windowed);
            }
            if (ResolutionIndex == 12)
            {
                if (displayModeIndex == 0)
                    Screen.SetResolution(1280, 800, FullScreenMode.FullScreenWindow);
                else if (displayModeIndex == 1)
                    Screen.SetResolution(1280, 800, FullScreenMode.MaximizedWindow);
                else if (displayModeIndex == 2)
                    Screen.SetResolution(1280, 800, FullScreenMode.Windowed);
            }
            if (ResolutionIndex == 13)
            {
                if (displayModeIndex == 0)
                    Screen.SetResolution(1920, 1200, FullScreenMode.FullScreenWindow);
                else if (displayModeIndex == 1)
                    Screen.SetResolution(1920, 1200, FullScreenMode.MaximizedWindow);
                else if (displayModeIndex == 2)
                    Screen.SetResolution(1920, 1200, FullScreenMode.Windowed);
            }
            Resolutionchanged = false;
        }
    }
}
