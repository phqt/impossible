using UnityEngine;

public class PuzzlePiece : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;

    private bool isSnapped = false;
    private bool isDragging = false;

    public delegate void OnPieceSnapEvent();
    public event OnPieceSnapEvent OnPieceSnap;

    void OnMouseDown()
    {
        if (!isSnapped)
        {
            isDragging = true;
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        }
    }

    void OnMouseDrag()
    {
        if (isDragging)
        {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            transform.position = curPosition;
        }
    }

    void OnMouseUp()
    {
        isDragging = false;
    }
}
