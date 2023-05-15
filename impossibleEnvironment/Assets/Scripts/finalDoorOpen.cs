using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalDoorOpen : MonoBehaviour
{

    public GameObject doorTrigger;
    public GameObject player;
    public string triggerTag = "Player";


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(triggerTag))
        {

        }
    }
}
