using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerHammerGlass : MonoBehaviour
{
    public GameObject hammerTool;
    public AudioSource glassBreak;
    public string triggerTag = "Hammer";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(triggerTag))
        {
            glassBreak.Play();
        }
    }
}
