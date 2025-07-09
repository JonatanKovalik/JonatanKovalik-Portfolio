using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;



public class AudioSettingsScript : MonoBehaviour

{

    public Scrollbar masterVolumeScrollBar;

    public Scrollbar musicVolumeScrollBar;

    public Scrollbar sfxVolumeScrollBar;

    public Scrollbar VoiceVolumeScrollBar;

    public Button Subtitiles;



    private int masterVolume = 100;

    private int musicVolume = 75;

    private int sfxVolume = 100;

    private int voiceVolume = 100;

    private bool subtitlesEnabled = true;





    void Start()

    {

        if (subtitlesEnabled)

        {

            subtitlesEnabled = false;

            Subtitiles.GetComponentInChildren<Text>().text = "ON";

            Subtitiles.GetComponent<Image>().color = Color.green;

            Debug.Log("Subtitles Disabled");

        }

        else

        {

            subtitlesEnabled = true;

            Subtitiles.GetComponentInChildren<Text>().text = "OFF";

            Subtitiles.GetComponent<Image>().color = Color.red;

            Debug.Log("Subtitles Enabled");

        }

    }





    public void MasterVolumeChange(float value)

    {

        masterVolume = masterVolumeScrollBar.value > 0 ? (int)(masterVolumeScrollBar.value * 100) : 0;

        Debug.Log("Master Volume: " + masterVolume);

    }



    public void MusicVolumeChange(float value)

    {

        musicVolume = musicVolumeScrollBar.value > 0 ? (int)(musicVolumeScrollBar.value * 100) : 0;

        Debug.Log("Music Volume: " + musicVolume);

    }



    public void SFXVolumeChange(float value)

    {

        sfxVolume = sfxVolumeScrollBar.value > 0 ? (int)(sfxVolumeScrollBar.value * 100) : 0;

        Debug.Log("SFX Volume: " + sfxVolume);

    }

    public void VoicesVolumeChange(float value)

    {

        voiceVolume = VoiceVolumeScrollBar.value > 0 ? (int)(VoiceVolumeScrollBar.value * 100) : 0;

        Debug.Log("Voices Volume: " + voiceVolume);

    }



    public void subtitlesbuttonclickd()

    {

        if (subtitlesEnabled)

        {

            subtitlesEnabled = false;

            Subtitiles.GetComponentInChildren<Text>().text = "ON";

            Subtitiles.GetComponent<Image>().color = Color.red;

            Debug.Log("Subtitles Disabled");

        }

        else

        {

            subtitlesEnabled = true;

            Subtitiles.GetComponentInChildren<Text>().text = "OFF";

            Subtitiles.GetComponent<Image>().color = Color.green;

            Debug.Log("Subtitles Enabled");

        }

    }



    void Update()

    {



    }

}