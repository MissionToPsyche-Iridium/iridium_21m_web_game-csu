using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class IntroTextFader : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public float fadeDuration = 2f;
    public float delayBeforeContinueText = 2f;
    public string continueMessage = "\n\nPress SPACE to continue";
    public string nextSceneName = "MainMenu";

    private bool canContinue = false;
    private TextMeshProUGUI textComponent;

    void Start()
    {
        canvasGroup.alpha = 0f;
        textComponent = GetComponent<TextMeshProUGUI>();
        StartCoroutine(FadeIn());
    }

    void Update()
    {
        if (canContinue && Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(FadeOutAndLoad());
        }
    }

    System.Collections.IEnumerator FadeIn()
    {
        float elapsed = 0f;
        while (elapsed < fadeDuration)
        {
            canvasGroup.alpha = Mathf.Lerp(0f, 1f, elapsed / fadeDuration);
            elapsed += Time.deltaTime;
            yield return null;
        }
        canvasGroup.alpha = 1f;

        yield return new WaitForSeconds(delayBeforeContinueText);

        textComponent.text += continueMessage;
        canContinue = true;
    }

    System.Collections.IEnumerator FadeOutAndLoad()
    {
        float elapsed = 0f;
        canContinue = false;
        while (elapsed < fadeDuration)
        {
            canvasGroup.alpha = Mathf.Lerp(1f, 0f, elapsed / fadeDuration);
            elapsed += Time.deltaTime;
            yield return null;
        }
        canvasGroup.alpha = 0f;
        SceneManager.LoadScene(nextSceneName);
    }
}
