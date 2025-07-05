using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Timeline;
using UnityEngine.Playables;

public class MainMenuSceneScript : MonoBehaviour
{
    public Material outlinemat;
    private Renderer objrender;
    private Material originalmat;
    public TextMeshProUGUI PlayText;
    public Camera Maincamera;
    public PlayableDirector cameradir;
    private bool isplaying = false;

    void Start()
    {
        isplaying = false;
        Maincamera.transform.position = new Vector3(-7.94f, 1.4f, 12.48f);
        if (PlayText != null)
        {
            PlayText.gameObject.SetActive(false);
        }
        objrender = GetComponent<Renderer>();
        if (objrender != null)
        {
            originalmat = objrender.material;
        }
    }

    private void OnMouseEnter()
    {
        if (isplaying == false)
        {
            if (objrender != null && outlinemat != null)
            {
                objrender.material = outlinemat;
            }
            if (PlayText != null)
            {
                PlayText.gameObject.SetActive(true);
            }
        }
    }

    private void OnMouseDown()
    {
        if (cameradir != null)
        {
            isplaying = true;
            objrender.material = originalmat;
            PlayText.gameObject.SetActive(false);
            cameradir.Play();
        }
    }

    private void OnMouseExit()
    {
        if (objrender != null && originalmat != null)
        {
            objrender.material = originalmat;
        }
        if (PlayText != null)
        {
            PlayText.gameObject.SetActive(false);
        }
    }

    void Update()
    {

    }
}