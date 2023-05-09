using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchCameraBox : MonoBehaviour
{

    public GameObject camOne;
    public GameObject camTwo;
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        camOne.SetActive(true);
        camTwo.SetActive(false);
    }

    public void OnTriggerExit(Collider other)
    {
        camOne.SetActive(false);
        camTwo.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
