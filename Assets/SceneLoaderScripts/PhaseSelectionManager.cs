using UnityEngine;
using UnityEngine.SceneManagement;

public class PhaseSelectionManager : MonoBehaviour
{
    // Called when the player selects a specific minigame
    public void LoadPhase(string phaseSceneName)
    {
        SceneManager.LoadScene(phaseSceneName);
    }
}
