using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void GoToA()
    {
        SceneManager.LoadScene("PhaseA");
    }
    
    public void GoToB()
    {
        SceneManager.LoadScene("Start");
    }

    public void GoToBGame()
    {
        SceneManager.LoadScene("Quiz");
    }

    public void GoToBEnd()
    {
        SceneManager.LoadScene("Quiz End");
    }

    public void GoToC()
    {
        SceneManager.LoadScene("Start 2");
    }

    public void GoToCGame()
    {
        SceneManager.LoadScene("Puzzle Game");
    }

    public void GoToCEnd()
    {
        SceneManager.LoadScene("Puzzle End");
    }

    public void GoToD()
    {
        SceneManager.LoadScene("LV 0 - Intro");
    }

    public void GoToE()
    {
        SceneManager.LoadScene("Introduction");
    }

    public void GoToF()
    {
        SceneManager.LoadScene("PhaseF");
    }

    public void GoToPhaseSelect()
    {
        SceneManager.LoadScene("Phase Select");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void GoToLv1()
    {
        SceneManager.LoadScene("LV 1 - Vibration");
    }
    public void GoToLv2()
    {
        SceneManager.LoadScene("LV 2 - Thermal");
    }
    public void GoToLv3()
    {
        SceneManager.LoadScene("LV 3 - Electro");
    }
    public void GoToLv4()
    {
        SceneManager.LoadScene("LV 4 - Launch");
    }

    public void GoToDisclaimer()
    {
        SceneManager.LoadScene("Disclaimer");
    }
}