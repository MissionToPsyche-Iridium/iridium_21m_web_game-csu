using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class scriptDiaglog : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed = 0.05f;

    public AudioManager audioManager; // Assign in Inspector

    private int index;
    private bool isTyping = false;

    void Start()
    {
        if (audioManager == null)
            Debug.LogWarning("AudioManager is not assigned in the Inspector!");

        textComponent.text = string.Empty;

        // Delay typing start to allow AudioManager to initialize
        StartCoroutine(DelayedStart());
    }

    IEnumerator DelayedStart()
    {
        yield return new WaitForSeconds(0.1f); // delay for proper init
        StartDialogue();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (isTyping)
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
                isTyping = false;
                audioManager.StopTypeSound(); // Stop sound when skipping
            }
            else
            {
                NextLine();
            }
        }
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        isTyping = true;
        textComponent.text = string.Empty;

        audioManager.PlayTypeSound(); // Start typing sound

        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }

        isTyping = false;
        audioManager.StopTypeSound(); // Stop after typing ends
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            StartCoroutine(TypeLine());
        }
        else
        {
            LoadNextScene();
        }
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene("MainGame");
    }
}
