using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerDoorOpen : MonoBehaviour
{
    public Animator triggerDoor;
    bool animDoor;


    public void Start()
    {
        //animDoor = false;
        triggerDoor = GameObject.FindGameObjectWithTag("Red Door").GetComponent<Animator>();
    }
    
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")&&(Input.GetKeyDown(KeyCode.E)))
        {
            triggerDoor.SetTrigger("DoorOpen");
            animDoor = true;
        }
    }
    
}
