using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsAnimationLine : MonoBehaviour
{
    public Text line1;
    public Text line2;
    public Text line3;
    public Text line4;

    public static bool displaybutton = false;
    public static bool audiobutton = false;
    public static bool controlbutton = false;
    public static bool accessibilitybutton = false;

    public static bool check2 = false;

    private string check;

    private void Start()
    {
        line1.text = "";
        line2.text = "";
        line3.text = "";
        line4.text = "";
    }

    private void Update()
    {
        if(AnimationButtonsAndImagetoSide.options2 == true && check2 == false)
        {
            Debug.Log("Options Animation Line Start");
            check2 = true;
            check = "DisplayButton";
            StartCoroutine(lineanimation());
            displaybutton = true;
        }
    }

    public void DisplayButtonClick()
    {
        check = "DisplayButton";
        StartCoroutine(lineanimation());
        displaybutton = true;
        audiobutton = false;
        controlbutton = false;
        accessibilitybutton = false;
    }

    public void AudioButtonClick()
    {
        check = "AudioButton";
        StartCoroutine(lineanimation());
        audiobutton = true;
        displaybutton = false;
        controlbutton = false;
        accessibilitybutton = false;
    }

    public void ControlButtonClick()
    {
        check = "ControlButton";
        StartCoroutine(lineanimation());
        controlbutton = true;
        displaybutton = false;
        audiobutton = false;
        accessibilitybutton = false;
    }

    public void AccessibilityButtonClick()
    {
        check = "AccessibilityButton";
        StartCoroutine(lineanimation());
        accessibilitybutton = true;
        displaybutton = false;
        audiobutton = false;
        controlbutton = false;
    }

    private IEnumerator lineanimation()
    {
        if (check == "DisplayButton")
        {
            while (line1.text.Length != 13)
            {
                line1.text += "_";
                yield return new WaitForSeconds(0.01f);
            }

            while(line2.text.Length != 0)
            {
                line2.text = line2.text.Remove(line2.text.Length - 1);
                yield return new WaitForSeconds(0.01f);
            }
            while (line3.text.Length != 0)
            {
                line3.text = line3.text.Remove(line3.text.Length - 1);
                yield return new WaitForSeconds(0.01f);
            }
            while (line4.text.Length != 0)
            {
                line4.text = line4.text.Remove(line4.text.Length - 1);
                yield return new WaitForSeconds(0.01f);
            }
        }

        if (check == "AudioButton")
        {
            while (line2.text.Length != 12)
            {
                line2.text += "_";
                yield return new WaitForSeconds(0.01f);
            }
            while (line1.text.Length != 0)
            {
                line1.text = line1.text.Remove(line1.text.Length - 1);
                yield return new WaitForSeconds(0.01f);
            }
            while (line3.text.Length != 0)
            {
                line3.text = line3.text.Remove(line3.text.Length - 1);
                yield return new WaitForSeconds(0.01f);
            }
            while (line4.text.Length != 0)
            {
                line4.text = line4.text.Remove(line4.text.Length - 1);
                yield return new WaitForSeconds(0.01f);
            }
        }

        if(check == "ControlButton")
        {
            while (line3.text.Length != 14)
            {
                line3.text += "_";
                yield return new WaitForSeconds(0.01f);
            }
            while (line2.text.Length != 0)
            {
                line2.text = line2.text.Remove(line2.text.Length - 1);
                yield return new WaitForSeconds(0.01f);
            }
            while (line1.text.Length != 0)
            {
                line1.text = line1.text.Remove(line1.text.Length - 1);
                yield return new WaitForSeconds(0.01f);
            }
            while (line4.text.Length != 0)
            {
                line4.text = line4.text.Remove(line4.text.Length - 1);
                yield return new WaitForSeconds(0.01f);
            }
        }

        if(check == "AccessibilityButton")
        {
            while (line4.text.Length != 17)
            {
                line4.text += "_";
                yield return new WaitForSeconds(0.01f);
            }
            while (line1.text.Length != 0)
            {
                line1.text = line1.text.Remove(line1.text.Length - 1);
                yield return new WaitForSeconds(0.01f);
            }
            while (line3.text.Length != 0)
            {
                line3.text = line3.text.Remove(line3.text.Length - 1);
                yield return new WaitForSeconds(0.01f);
            }
            while (line2.text.Length != 0)
            {
                line2.text = line2.text.Remove(line2.text.Length - 1);
                yield return new WaitForSeconds(0.01f);
            }
        }
    }
}
