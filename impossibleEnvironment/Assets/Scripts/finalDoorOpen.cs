using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalDoorOpen : MonoBehaviour
{

    public GameObject doorTrigger;
    public GameObject player;
    public string triggerTag = "Player";
    public Animator finalPlay;
    public GameObject pictureImage;
   

    public void Start()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(triggerTag))
        {
            finalPlay.SetTrigger("finalopen");
            pictureImage.SetActive(true);

        }

    }

    

}
