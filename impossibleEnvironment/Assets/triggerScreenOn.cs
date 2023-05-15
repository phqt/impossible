using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerScreenOn : MonoBehaviour
{
    public GameObject strangeScreen;

    public AudioSource bgmSound;
    public AudioSource compSound;
    public GameObject lightOne;
    public GameObject lightTwo;
  
    public string triggerTag = "Player";

    public void Start()
    {
        compSound.Stop();
    }
    // Called when a GameObject enters the trigger
    void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag(triggerTag))
        {
            
             strangeScreen.SetActive(false);
            lightOne.SetActive(true);
            lightTwo.SetActive(true);
            bgmSound.Stop();
            compSound.Play();

        }
    }
    
    
    
}
