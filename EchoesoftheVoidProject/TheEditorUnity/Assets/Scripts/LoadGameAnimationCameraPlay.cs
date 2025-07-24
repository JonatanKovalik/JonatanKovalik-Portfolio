using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static ButtonFunction;
using UnityEngine.SceneManagement;

public class LoadGameAnimationCameraPlay : MonoBehaviour
{
    public Camera Camera;
    private bool check = false;
    public Canvas canvas;

    void Update()
    {
        if(loadgame == true && check == false)
        {
            canvas.enabled = false;
            Animator animatorcamera = Camera.GetComponent<Animator>();
            animatorcamera.enabled = true;
            StartCoroutine(loadsceneandwaitanimationend());
            check = true;
        }
    }
    private IEnumerator loadsceneandwaitanimationend()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("LoadingDataSaveGameScreen");
    }
}
