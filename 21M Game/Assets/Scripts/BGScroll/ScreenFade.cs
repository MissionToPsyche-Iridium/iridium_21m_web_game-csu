using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class ScreenFade : MonoBehaviour
{
    public Image fadeImage;
    public float fadeSpeed = 1f;
    public bool fadeInOnStart = true;
    public string nextSceneName = "MainGame"; // Only for intro scene

    private void Start()
    {
        if (fadeInOnStart)
        {
            fadeImage.color = Color.white;
            StartCoroutine(FadeIn());
        }
    }

    public void StartFadeOut()
    {
        StartCoroutine(FadeOut());
    }

    private IEnumerator FadeIn()
    {
        Color c = fadeImage.color;
        while (c.a > 0f)
        {
            c.a -= fadeSpeed * Time.deltaTime;
            fadeImage.color = c;
            yield return null;
        }
        c.a = 0f;
        fadeImage.color = c;
    }

    private IEnumerator FadeOut()
    {
        Color c = fadeImage.color;
        while (c.a < 1f)
        {
            c.a += fadeSpeed * Time.deltaTime;
            fadeImage.color = c;
            yield return null;
        }
        c.a = 1f;
        fadeImage.color = c;

        // After fade to white, load next scene
        SceneManager.LoadScene(nextSceneName);
    }
}
