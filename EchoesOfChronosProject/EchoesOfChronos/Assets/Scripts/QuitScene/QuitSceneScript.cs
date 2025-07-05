using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.Playables;

public class QuitSceneScript : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public Light lightobj;
    public PlayableDirector cameradir;
    private bool animationend = false;

    void Start()
    {
        Text.gameObject.SetActive(false);
        lightobj.intensity = 0f;
        if (cameradir != null)
        {
            cameradir.Play();
            animationend = true;
        }
    }

    void functiononetime()
    {
        if (lightobj.intensity >= 2)
        {
            Thread.Sleep(1000);
            Text.gameObject.SetActive(true);
        }
    }

    void Update()
    {
        if(animationend == true && cameradir.state != PlayState.Playing)
        {
            while(lightobj.intensity <= 2)
            {
                lightobj.intensity += 0.003f;
                break;
            }
            functiononetime();
        }
    }
}
