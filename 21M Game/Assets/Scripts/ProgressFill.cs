using UnityEngine;
using UnityEngine.UI;

public class ProgressFill : MonoBehaviour
{
    public Slider progressBar; 
    public GameObject popup;


    public void UpdateProgress()
    {
        // Increment the progress bar's value
        progressBar.value += 0.1f; 

        // Popup active when bar is full
        if (progressBar.value == 1f)
            popup.SetActive(true);
    }

    public void LaunchProgress()
    {
        // Slower increment for Launch
        progressBar.value += 0.02f; 

        if (progressBar.value == 1f)
            popup.SetActive(true);
    }
}