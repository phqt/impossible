using UnityEngine;
using UnityEngine.Events;

public class Puzzle : MonoBehaviour
{
    public float snapDistance = 0.5f; // The maximum distance between two pieces for them to snap together
    public GameObject[] puzzlePieces; // An array of all the puzzle pieces that make up the puzzle
    public UnityEvent onPuzzleComplete; // An event to trigger when the puzzle is complete

    private bool[] piecesConnected; // An array to keep track of which pieces have been connected to the puzzle

    private void Start()
    {
        piecesConnected = new bool[puzzlePieces.Length];
    }

    private void FixedUpdate()
    {
        // Loop through all the puzzle pieces
        for (int i = 0; i < puzzlePieces.Length; i++)
        {
            // If this piece has already been connected, skip it
            if (piecesConnected[i]) continue;

            // Loop through all the other puzzle pieces
            for (int j = 0; j < puzzlePieces.Length; j++)
            {
                // If this piece is the same as the first piece, skip it
                if (i == j) continue;

                // Calculate the distance between the two puzzle pieces
                float distance = Vector3.Distance(puzzlePieces[i].transform.position, puzzlePieces[j].transform.position);

                // If the distance is less than the snap distance, snap the two pieces together
                if (distance < snapDistance)
                {
                    // Set the position of the first piece to the position of the second piece
                    puzzlePieces[i].transform.position = puzzlePieces[j].transform.position;

                    // Mark both pieces as connected
                    piecesConnected[i] = true;
                    piecesConnected[j] = true;
                }
            }
        }

        // Check if all the pieces are connected
        if (AllPiecesConnected())
        {
            // Trigger the onPuzzleComplete event
            onPuzzleComplete.Invoke();
        }
    }

    private bool AllPiecesConnected()
    {
        // Loop through all the puzzle pieces
        for (int i = 0; i < puzzlePieces.Length; i++)
        {
            // If this piece is not connected, return false
            if (!piecesConnected[i]) return false;
        }

        // All pieces are connected
        return true;
    }
}
