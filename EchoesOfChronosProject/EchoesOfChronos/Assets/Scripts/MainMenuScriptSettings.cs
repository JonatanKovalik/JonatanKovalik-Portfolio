using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class MainMenuScriptSettings : MonoBehaviour
{
    public Material outlinemat;
    private Renderer objrender;
    private Material originalmat;
    public TextMeshProUGUI SettingsText;
    public Camera Maincamera;
    public PlayableDirector cameradir;
    private bool isplaying = false;
    public GameObject startplay;
    public GameObject quit;
    private bool isanimationend = false;

    void Start()
    {
        isplaying = false;
        Maincamera.transform.position = new Vector3(-7.94f, 1.4f, 12.48f);
        if (SettingsText != null)
        {
            SettingsText.gameObject.SetActive(false);
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
            if (SettingsText != null)
            {
                SettingsText.gameObject.SetActive(true);
            }
        }
    }

    private void OnMouseDown()
    {
        if (cameradir != null)
        {
            isplaying = true;
            if (startplay != null)
            {
                BoxCollider settingsCollider = startplay.GetComponent<BoxCollider>();
                if (settingsCollider != null)
                {
                    settingsCollider.enabled = false;
                }
            }

            if (quit != null)
            {
                BoxCollider quitCollider = quit.GetComponent<BoxCollider>();
                if (quitCollider != null)
                {
                    quitCollider.enabled = false;
                }
            }
            objrender.material = originalmat;
            SettingsText.gameObject.SetActive(false);
            cameradir.Play();
            isanimationend = true;
        }
    }

    private void OnMouseExit()
    {
        if (objrender != null && originalmat != null)
        {
            objrender.material = originalmat;
        }
        if (SettingsText != null)
        {
            SettingsText.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if(cameradir.state != PlayState.Playing && isanimationend == true)
        {
            SceneManager.LoadScene("SettingsMenuScene");
        }
    }
}
