using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFunction : MonoBehaviour
{

    public GameObject panelblack;
    public GameObject panelexit;
    public static bool movebuttonandimage = false;

    public void startnewgamefunction()
    {
        movebuttonandimage = true;
    }

    public void loadgamefunction()
    {
        movebuttonandimage = true;
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
