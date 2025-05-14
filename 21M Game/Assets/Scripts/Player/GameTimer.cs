using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour
{
    public Slider progressBar;
    public float totalTime = 60f; // 1 minute
    private float elapsedTime = 0f;
    private bool gameEnded = false;

    void Start()
    {
        if (progressBar != null)
        {
            progressBar.maxValue = 1f;
            progressBar.value = 0f;
        }
    }

    void Update()
    {
        if (gameEnded) return;

        elapsedTime += Time.deltaTime;

        if (progressBar != null)
        {
            progressBar.value = elapsedTime / totalTime;
        }

        if (elapsedTime >= totalTime)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        gameEnded = true;
        Time.timeScale = 1f; // ensure normal time scale before transition
        SceneManager.LoadScene("Finish");
    }
}
