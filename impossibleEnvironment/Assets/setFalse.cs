using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setFalse : MonoBehaviour
{
    public GameObject thisThing;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pickup")
        {
            thisThing.SetActive(false);
        }
    }
}
