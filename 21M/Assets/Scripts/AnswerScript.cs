using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class AnswerScript : MonoBehaviour
{
    


    public bool isCorrect = false;
   

    //make a reference for QuizManager
    public QuizManager quizManager;
    public Color startColor;

    public Text message; 

    private void Start()
    {
        startColor = GetComponent<Image>().color;
        message.text = ""; 
    }
    public void Answer()
    {
        if (isCorrect)
        {
            GetComponent<Image>().color = Color.green;
            message.text = "Correct Answer!";
            Debug.Log("Correct Answer");
            quizManager.correct();
        }
        else
        {
            GetComponent<Image>().color = Color.red;
            message.text = "Incorrect Answer!";
            Debug.Log("Incorrect Answer");
            quizManager.wrong();
        }

        Invoke("ClearMessage", 1.0f);

    }

    void ClearMessage()
    {
        message.text = "";
    }

}
