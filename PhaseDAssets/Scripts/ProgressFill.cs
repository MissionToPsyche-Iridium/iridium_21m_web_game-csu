using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class ProgressFill : MonoBehaviour
{
    public Slider progressBar; // Assign in the Inspector
    public GameObject popup;


    public void UpdateProgress()
    {
        // Increment the progress bar's value
        progressBar.value += 0.1f; // Adjust increment value as needed

        
        if (progressBar.value == 1f)
            popup.SetActive(true);
    }

    public void LaunchProgress()
    {
        // Increment the progress bar's value
        progressBar.value += 0.02f; // Adjust increment value as needed

        if (progressBar.value == 1f)
            popup.SetActive(true);
    }
}