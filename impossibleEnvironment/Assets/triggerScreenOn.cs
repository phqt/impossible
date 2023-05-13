using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerScreenOn : MonoBehaviour
{
    public GameObject strangeScreen;

    
  
    public string triggerTag = "Player";

    // Called when a GameObject enters the trigger
    void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag(triggerTag))
        {
            
             strangeScreen.SetActive(false);
        }
    }
    
    
    
}
