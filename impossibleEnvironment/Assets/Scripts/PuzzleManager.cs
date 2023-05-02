using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public Collider puzzleCompleteCollider; // Assign this in the Inspector

    private List<PuzzlePiece> puzzlePieces = new List<PuzzlePiece>();

    void Start()
    {
        PuzzlePiece[] pieces = GetComponentsInChildren<PuzzlePiece>();
        foreach (PuzzlePiece piece in pieces)
        {
            puzzlePieces.Add(piece);
        }
    }

    void Update()
    {
        bool allWithinCollider = true;
        foreach (PuzzlePiece piece in puzzlePieces)
        {
            if (!puzzleCompleteCollider.bounds.Contains(piece.transform.position))
            {
                allWithinCollider = false;
                break;
            }
        }
        if (allWithinCollider)
        {
            Debug.Log("Puzzle complete!");
            // Trigger whatever event you need here
        }
    }
}
