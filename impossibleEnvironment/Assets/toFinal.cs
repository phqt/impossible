using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toFinal : MonoBehaviour
{
    // The tag of the GameObjects that can trigger the scene switch
    public string triggerTag = "Player";

    // Called when a GameObject enters the trigger
    void OnTriggerEnter(Collider other)
    {
        // Check if the GameObject has the specified tag
        if (other.CompareTag(triggerTag))
        {
            // Load the next scene
            SceneManager.LoadScene(7);
        }
    }
}
