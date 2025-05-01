using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Called when player clicks "View Disclaimer"
    public void LoadDisclaimer()
    {
        SceneManager.LoadScene("Disclaimer");
    }

    // Called when player clicks "Start From Beginning"
    public void StartGameFromBeginning()
    {
        SceneManager.LoadScene("PhaseA"); // or the first scene of your game
    }

    // Called when the player clicks "Select a Phase to Start"
    public void LoadPhaseSelectionMenu()
    {
        SceneManager.LoadScene("PhaseSelectionMenu");
    }

    // Called when the player clicks the "return" button in phase selection screen to return to main menu
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // Optional: Quit the game (only works in built game, not in editor)
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game quit!");
    }
}
