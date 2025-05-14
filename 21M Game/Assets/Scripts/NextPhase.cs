using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class NextPhase : MonoBehaviour
{
    public void nextGame()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void game4()
    {
        SceneManager.LoadSceneAsync(0); //change the index according to which game you want to load

    }
}
