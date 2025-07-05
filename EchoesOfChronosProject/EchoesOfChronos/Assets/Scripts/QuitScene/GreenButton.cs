using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class GreenButton : MonoBehaviour
{
    public PlayableDirector cameradir;

    private Vector3 originalPosition;
    private Vector3 pressedPosition;

    public float animationDuration = 0.1f;
    public float holdDuration = 0.1f;

    private bool isAnimating = false;

    void Start()
    {
        originalPosition = new Vector3(-6.707014f, 1.341034f, 6.326228f);
        pressedPosition = new Vector3(-6.707014f, 1.301f, 6.326228f);

        transform.position = originalPosition;
    }

    void OnMouseDown()
    {
        if (!isAnimating)
        {
            StartCoroutine(PressButtonAnimation());

            if (cameradir != null)
            {
                cameradir.Play();
            }
        }
    }

    IEnumerator PressButtonAnimation()
    {
        isAnimating = true;

        float timer = 0f;
        Vector3 startPos = transform.position;

        while (timer < animationDuration)
        {
            timer += Time.deltaTime;
            float t = timer / animationDuration;
            transform.position = Vector3.Lerp(startPos, pressedPosition, t);
            yield return null;
        }
        transform.position = pressedPosition;

        yield return new WaitForSeconds(holdDuration);

        timer = 0f;
        startPos = transform.position;

        while (timer < animationDuration)
        {
            timer += Time.deltaTime;
            float t = timer / animationDuration;
            transform.position = Vector3.Lerp(startPos, originalPosition, t);
            yield return null;
        }
        transform.position = originalPosition;

        isAnimating = false;
    }
}