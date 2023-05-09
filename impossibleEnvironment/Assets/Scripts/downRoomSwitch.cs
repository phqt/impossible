using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class downRoomSwitch : MonoBehaviour
{
    // The name of the scene to switch to

    // The duration of the delay in seconds
    public float delayDuration = 15f;

    public GameObject camOne;
    public GameObject camTwo;

    // Start is called before the first frame update
    void Start()
    {
        // Start the delay coroutine
        StartCoroutine(DelaySwitch());
    }

    IEnumerator DelaySwitch()
    {
        // Wait for the specified delay duration
        yield return new WaitForSeconds(delayDuration);

        // Load the next scene
        //SceneManager.LoadScene(0);
        camOne.SetActive(false);
        camTwo.SetActive(true);
    }
}
