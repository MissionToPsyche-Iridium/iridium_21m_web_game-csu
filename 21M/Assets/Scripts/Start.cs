using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    //create a method to begin game
    public void startGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void startGame2()
    {
        SceneManager.LoadSceneAsync(3);
    }
}
