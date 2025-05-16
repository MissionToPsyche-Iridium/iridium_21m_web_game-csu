using UnityEngine;
using UnityEngine.SceneManagement;

public class PointsHandler: MonoBehaviour
{
    private int totalPieces = 6; // set this to however many pieces you have
    private int placedPieces = 0;

    public GameObject popup;

    public void PiecePlaced()
    {
        placedPieces++;

        if (placedPieces >= totalPieces)
        {
            Debug.Log("Puzzle completed!");
            // Load next scene
            popup.SetActive(true);
        }
    }
}
