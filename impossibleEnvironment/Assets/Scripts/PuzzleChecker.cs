using UnityEngine;

public class PuzzleChecker : MonoBehaviour
{
    public GameObject puzzlePiecesParent;
    public BoxCollider puzzleBounds;
    public GameObject playerAfterBent;
    public GameObject bentItself;
    public GameObject playerPost;
    public GameObject warningTape;
    public GameObject tapeBox;
    public GameObject clothesTwo;
    void Update()
    {
        bool allPiecesInBounds = true;

        // Check if all puzzle pieces are within the bounds of the BoxCollider
        foreach (Transform piece in puzzlePiecesParent.transform)
        {
            if (!puzzleBounds.bounds.Contains(piece.position))
            {
                allPiecesInBounds = false;
                break;
            }
        }

        // If all puzzle pieces are within the bounds, print "puzzle done"
        if (allPiecesInBounds)
        {
            Debug.Log("Puzzle done!");
            playerAfterBent.SetActive(true);
            bentItself.SetActive(false);
            playerPost.SetActive(true);
            warningTape.SetActive(true);
            tapeBox.SetActive(true);
            clothesTwo.SetActive(true);
        }
    }
}
