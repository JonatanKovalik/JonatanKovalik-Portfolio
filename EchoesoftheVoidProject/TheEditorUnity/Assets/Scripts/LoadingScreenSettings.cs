using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScreenSettings : MonoBehaviour
{
    private int stage = 0;
    public Text stagetext;
    public Text datatext;

    private string[] loadingmeesage = new string[]
    {
        "Loading Game Data",
        "Compiling Shaders",
        "Loading Textures",
        "Initializing Audio Engine",
        "Setting Up World"
    };

    private int[] totalitemsdateperstage = new int[]
    {
        3021,  // Loading Game Data
        8765,  // Compiling Shaders
        12456, // Loading Textures
        987,   // Initializing Audio Engine
        5247   // Setting Up World
    };

    void Start()
    {
        StartCoroutine(Loading());
    }
    private IEnumerator Loading()
    {
        while(stage != 5)
        {
            if (stage == 0)
            {
                int x = 0;
                while (x != totalitemsdateperstage[stage])
                {
                    stagetext.text = loadingmeesage[stage];
                    datatext.text = x + "/" + totalitemsdateperstage[stage];
                    x+= Random.Range(60,101);
                    yield return new WaitForSeconds(Random.Range(0f, 0.06f));
                    if(x >= totalitemsdateperstage[stage])
                    {
                        break;
                    }
                }
                if (x >= totalitemsdateperstage[stage])
                {
                    stage++;
                }
            }
            if (stage == 1)
            {
                int x = 0;
                while (x != totalitemsdateperstage[stage])
                {
                    stagetext.text = loadingmeesage[stage];
                    datatext.text = x + "/" + totalitemsdateperstage[stage];
                    x += Random.Range(60, 101);
                    yield return new WaitForSeconds(Random.Range(0f, 0.06f));
                    if (x >= totalitemsdateperstage[stage])
                    {
                        break;
                    }
                }
                if (x >= totalitemsdateperstage[stage])
                {
                    stage++;
                }
            }

            if (stage == 2)
            {
                int x = 0;
                while (x != totalitemsdateperstage[stage])
                {
                    stagetext.text = loadingmeesage[stage];
                    datatext.text = x + "/" + totalitemsdateperstage[stage];
                    x += Random.Range(60, 101);
                    yield return new WaitForSeconds(Random.Range(0f, 0.06f));
                    if (x >= totalitemsdateperstage[stage])
                    {
                        break;
                    }
                }
                if (x >= totalitemsdateperstage[stage])
                {
                    stage++;
                }
            }

            if (stage == 3)
            {
                int x = 0;
                while (x != totalitemsdateperstage[stage])
                {
                    stagetext.text = loadingmeesage[stage];
                    datatext.text = x + "/" + totalitemsdateperstage[stage];
                    x += Random.Range(60, 101);
                    yield return new WaitForSeconds(Random.Range(0f, 0.06f));
                    if (x >= totalitemsdateperstage[stage])
                    {
                        break;
                    }
                }
                if (x >= totalitemsdateperstage[stage])
                {
                    stage++;
                }
            }

            if (stage == 4)
            {
                int x = 0;
                while (x != totalitemsdateperstage[stage])
                {
                    stagetext.text = loadingmeesage[stage];
                    datatext.text = x + "/" + totalitemsdateperstage[stage];
                    x += Random.Range(60, 101);
                    yield return new WaitForSeconds(Random.Range(0f, 0.06f));
                    if (x >= totalitemsdateperstage[stage])
                    {
                        datatext.text = "Loading Complete!";
                        break;
                    }
                }
                if (x >= totalitemsdateperstage[stage])
                {
                    stage++;
                }
            }
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene("MainMenuScene");
        }
    }

}
