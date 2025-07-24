using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFunction : MonoBehaviour
{

    public GameObject panelblack;
    public GameObject panelexit;
    public GameObject newgamesettings;
    public static bool movebuttonandimage = false;
    public static bool startnewgame = false;
    public static bool loadgame = false;
    public Canvas canvas;

    public static bool options = false;

    public void startnewgamefunction()
    {
        try
        {
            PlayerPrefs.DeleteAll();
        }
        catch
        {
            Debug.LogError("Error deleting PlayerPrefs");
        }
        startnewgame = true;
        newgamesettings.SetActive(true);
        canvas.enabled = true;
    }

    public void loadgamefunction()
    {
        loadgame = true;
    }
    public void optionsfunction()
    {
        movebuttonandimage = true;
    }
    public void exitgamefunction()
    {
        panelexit.SetActive(true);
    }

    void Start()
    {
        panelblack.SetActive(false);
        panelexit.SetActive(false);
        newgamesettings.SetActive(false);
        canvas.enabled = true;
    }

}
