using UnityEngine;

public class openRedDoor : MonoBehaviour
{
    public Animator animator; // Reference to the animator component of the door
    public Collider doorCollider; // Reference to the collider of the door

    private bool isPlayerInside = false; // Flag to keep track of whether the player is inside the collider

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the object that entered the collider is the player
        {
            isPlayerInside = true; // Set the flag to true if the player entered the collider
            animator.SetBool("isOpen", true); // Trigger the door opening animation
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the object that exited the collider is the player
        {
            isPlayerInside = false; // Set the flag to false if the player exited the collider
            animator.SetBool("isOpen", false); // Trigger the door closing animation
        }
    }

    void Update()
    {
        if (isPlayerInside && Input.GetKeyDown(KeyCode.E)) // Check if the player is inside the collider and pressed the E key
        {
            animator.SetBool("isOpen", false); // Trigger the door closing animation
            isPlayerInside = false; // Reset the flag
        }
    }
}
