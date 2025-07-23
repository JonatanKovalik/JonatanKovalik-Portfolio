using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFunction : MonoBehaviour
{

    public GameObject panelblack;
    public GameObject panelexit;
    public static bool movebuttonandimage = false;
    public static bool startnewgame = false;
    public static bool loadgame = false;

    public void startnewgamefunction()
    {
        startnewgame = true;
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
    }

}
