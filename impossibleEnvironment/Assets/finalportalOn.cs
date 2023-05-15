using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalPortalOn : MonoBehaviour
{
    public GameObject portalBack;
    public GameObject portalIn;
    public string triggerTag = "Player";

    void OnTriggerEnter(Collider other)
    {
         if (other.CompareTag(triggerTag))
        {
            portalBack.SetActive(true);
            portalIn.SetActive(true);

        }
    }
}