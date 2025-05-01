using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("Lives & Health")]
    public int lives = 3;
    public Image healthImage;
    public Sprite threeHeartsSprite;
    public Sprite twoHeartsSprite;
    public Sprite oneHeartSprite;

    [Header("Game Over")]
    public GameObject gameOverPanel;

    [Header("Timer")]
    public Slider progressBar;
    public float totalTime = 60f; // 1 minute
    private float elapsedTime = 0f;

    private bool gameEnded = false;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        UpdateHealthUI();
        gameOverPanel.SetActive(false);

        if (progressBar != null)
        {
            progressBar.maxValue = 1f;
            progressBar.value = 0f;
        }
    }

    private void Update()
    {
        if (gameEnded) return;

        // Handle timer
        elapsedTime += Time.deltaTime;

        if (progressBar != null)
        {
            progressBar.value = elapsedTime / totalTime;
        }

        if (elapsedTime >= totalTime)
        {
            FinishGame();
        }
    }

    public void LoseLife()
    {
        if (gameEnded) return;

        lives--;
        UpdateHealthUI();

        if (lives <= 0)
        {
            GameOver();
        }
    }

    private void UpdateHealthUI()
    {
        if (lives == 3)
            healthImage.sprite = threeHeartsSprite;
        else if (lives == 2)
            healthImage.sprite = twoHeartsSprite;
        else if (lives == 1)
            healthImage.sprite = oneHeartSprite;
        else if (lives <= 0)
            healthImage.enabled = false; // hide the heart when no lives left
    }

    private void GameOver()
    {
        gameEnded = true;
        Time.timeScale = 0f;
        gameOverPanel.SetActive(true);
    }

    private void FinishGame()
    {
        gameEnded = true;
        Time.timeScale = 1f; // reset timescale just in case
        Debug.Log("Timer complete. Loading Finish scene...");
        SceneManager.LoadScene("Finish");
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
