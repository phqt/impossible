using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneControllerIntro : MonoBehaviour
{
    public float cutsceneDuration = 24f;

    // Start is called before the first frame update
    void Start()
    {
        // Start the cutscene coroutine
        StartCoroutine(StartCutscene());
    }

    IEnumerator StartCutscene()
    {
        // Wait for the specified duration
        yield return new WaitForSeconds(cutsceneDuration);

        // Load the next scene
        SceneManager.LoadScene("SampleScene");
    }
}
