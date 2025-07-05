using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class RedButton : MonoBehaviour
{
    public GameObject thebutton;
    public PlayableDirector buttondir;
    private bool isplaying = false;

    private void Start()
    {
    }

    private void OnMouseDown()
    {
        if (isplaying == false)
        {
            buttondir.Play();
            isplaying = true;
        }
        if (buttondir.state != PlayState.Playing && isplaying == true)
        {
            Application.Quit();
        }
    }
}
