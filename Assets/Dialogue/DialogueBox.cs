using System.Collections;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI dialogueText; // Reference to the UI Text component
    public float letterSpeed = 0.05f; // Speed at which letters appear
    public string[] dialogueSegments; // Array of dialogue strings
    public UnityEngine.UI.Image backgroundImage; // Reference to the UI background image
    public Sprite[] backgroundSprites; // One sprite for each dialogue segment

    private int currentSegmentIndex = 0;
    private bool isTyping = false;
    private Coroutine typingCoroutine;

    void Start()
    {
        if (dialogueSegments.Length > 0)
        {
            StartDialogue();
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isTyping)
            {
                // If text is still being typed, complete it instantly
                StopCoroutine(typingCoroutine);
                dialogueText.text = dialogueSegments[currentSegmentIndex];
                isTyping = false;
            }
            else
            {
                // Move to the next segment
                NextDialogueSegment();
            }
        }
    }

    void StartDialogue()
    {
        currentSegmentIndex = 0;
        ShowDialogueSegment();
    }

    void NextDialogueSegment()
    {
        if (currentSegmentIndex < dialogueSegments.Length - 1)
        {
            currentSegmentIndex++;
            ShowDialogueSegment();
        }
        else
        {
            dialogueText.text = ""; // Clear dialogue when finished
            Debug.Log("End of dialogue.");
        }
    }

    void ShowDialogueSegment()
    {
        dialogueText.text = "";

        // Set the background image if available
        if (backgroundSprites.Length > currentSegmentIndex && backgroundSprites[currentSegmentIndex] != null)
        {
            backgroundImage.sprite = backgroundSprites[currentSegmentIndex];
        }

        typingCoroutine = StartCoroutine(TypeText(dialogueSegments[currentSegmentIndex]));
    }


    IEnumerator TypeText(string segment)
    {
        isTyping = true;
        dialogueText.text = "";
        foreach (char letter in segment.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(letterSpeed);
        }
        isTyping = false;
    }
}
