using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerTrigger : MonoBehaviour
{

    public AudioSource hammerSound;
    public string triggerTag = "Player";

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(triggerTag) && (Input.GetKey(KeyCode.E)))
        {
            hammerSound.Play();
        }
        else
        {
            hammerSound.Stop();
        }
    }
}
