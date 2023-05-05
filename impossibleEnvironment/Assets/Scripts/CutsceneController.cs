using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class CutsceneController : MonoBehaviour
{
    // The name of the scene to switch to
    //public string downRoom;

    // The duration of the cutscene in seconds
    public float cutsceneDuration = 10f;

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
        SceneManager.LoadScene(3);
    }
}
