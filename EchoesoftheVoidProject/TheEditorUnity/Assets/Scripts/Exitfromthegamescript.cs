using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exitfromthegamescript : MonoBehaviour
{
    public GameObject exitPanel;
    public void yesbuttonclick()
    {
        Debug.Log("Exit from the game");
        Application.Quit();
    }

    public void nobuttonclick()
    {
        Debug.Log("Exit cancelled");
        exitPanel.SetActive(false);
    }
}
