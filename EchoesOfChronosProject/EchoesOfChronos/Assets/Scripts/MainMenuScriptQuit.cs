using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class MainMenuScriptQuit : MonoBehaviour
{
    public Material outlinemat;
    private Renderer objrender;
    private Material originalmat;
    public TextMeshProUGUI QuitText;
    public Camera Maincamera;
    public PlayableDirector cameradir;
    private bool isplaying = false;
    public GameObject startplay;
    public GameObject settings;
    private bool isanimationend = false;

    void Start()
    {
        isplaying = false;
        Maincamera.transform.position = new Vector3(-7.94f, 1.4f, 12.48f);
        if (QuitText != null)
        {
            QuitText.gameObject.SetActive(false);
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
            if (QuitText != null)
            {
                QuitText.gameObject.SetActive(true);
            }
        }
    }

    private void OnMouseDown()
    {
        if (cameradir != null)
        {
            isplaying = true;
            if (settings != null)
            {
                BoxCollider settingsCollider = settings.GetComponent<BoxCollider>();
                if (settingsCollider != null)
                {
                    settingsCollider.enabled = false;
                }
            }

            if (startplay != null)
            {
                BoxCollider quitCollider = startplay.GetComponent<BoxCollider>();
                if (quitCollider != null)
                {
                    quitCollider.enabled = false;
                }
            }
            objrender.material = originalmat;
            QuitText.gameObject.SetActive(false);
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
        if (QuitText != null)
        {
            QuitText.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if (cameradir.state != PlayState.Playing && isanimationend == true)
        {
            SceneManager.LoadScene("QuitScene");
        }
    }
}
