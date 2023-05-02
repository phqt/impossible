using UnityEngine;

public class PuzzleChecker : MonoBehaviour
{
    public GameObject puzzlePiecesParent;
    public BoxCollider puzzleBounds;

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
        }
    }
}
