using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class toBent : MonoBehaviour
{
    public GameObject playerCam;
    public GameObject mainPost;
    public GameObject bentCam;
    public GameObject bentPost;
    public GameObject bentPlayer;
    public string triggerTag = "Player";
    public GameObject canvasUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(triggerTag))
        {
            playerCam.SetActive(false);
            mainPost.SetActive(false);
            bentCam.SetActive(true);
            bentPost.SetActive(true);
            bentPlayer.SetActive(true);
            canvasUI.SetActive(true);
        }
    }
}
