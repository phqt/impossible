using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;


public class toiletGame : MonoBehaviour
{
    public float fillSpeed = 0.5f;
    public float drainSpeed = 0.1f;
    public float winThreshold = 1f;
    public float loseThreshold = 0f;
    public AudioSource winAudio;
    public AudioSource loseAudio;
    public GameObject winCanvas;
    public GameObject loseCanvas;
    public VideoPlayer winVideoPlayer;
    public VideoPlayer loseVideoPlayer;
    public Image uiBar;
    private float fillAmount = 0f;
    private bool isPressed = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            isPressed = true;
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            isPressed = false;
        }

        if (isPressed && fillAmount < winThreshold)
        {
            fillAmount += fillSpeed * Time.deltaTime;
            uiBar.fillAmount = fillAmount;
        }
        else if (!isPressed && fillAmount > loseThreshold)
        {
            fillAmount -= drainSpeed * Time.deltaTime;
            uiBar.fillAmount = fillAmount;
        }

        if (fillAmount >= winThreshold)
        {
            Win();
        }
        else if (fillAmount <= loseThreshold)
        {
            Lose();
        }
    }

    void Win()
    {
        winAudio.Play();
        winCanvas.SetActive(true);
        winVideoPlayer.Play();
    }

    void Lose()
    {
        loseAudio.Play();
        loseCanvas.SetActive(true);
        loseVideoPlayer.Play();
    }
}
