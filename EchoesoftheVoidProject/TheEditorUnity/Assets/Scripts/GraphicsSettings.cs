using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static DisplaySettingsData;

public class GraphicsSettings : MonoBehaviour
{

    private void Update()
    {
        if(GraphicsChanged == true)
        {
            changegraphic();
            GraphicsChanged = false;
        }
    }

    private void changegraphic()
    {
        if (GraphicsIndex == 0)
        {
            QualitySettings.SetQualityLevel(6, true);
        }
        if (GraphicsIndex == 1)
        {
            QualitySettings.SetQualityLevel(5, true);
        }
        if (GraphicsIndex == 2)
        {
            QualitySettings.SetQualityLevel(4, true);
        }
        if (GraphicsIndex == 3)
        {
            QualitySettings.SetQualityLevel(3, true);
        }
        if (GraphicsIndex == 4)
        {
            QualitySettings.SetQualityLevel(2, true);
        }
        if (GraphicsIndex == 5)
        {
            QualitySettings.SetQualityLevel(1, true);
        }
        if (GraphicsIndex == 6)
        {
            QualitySettings.SetQualityLevel(0, true);
        }
    }

    private void Start()
    {

    }
}
