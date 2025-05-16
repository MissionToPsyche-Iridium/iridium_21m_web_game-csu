
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public List<QuestionAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public Text QuestionText;
    public GameObject Quizpanel;
    public GameObject Endpanel;
    public Text ScoreTxt;
    public int Score;
    public int Total;

    

    // public Color startColor; 
    private void Start()
    {
        
        Total = QnA.Count;
       Endpanel.SetActive(false);
 
        //generate question first
        generateQuestion();
    }

    //method to generate question
    void generateQuestion()
    {
        if(QnA.Count > 0)
        {
            //random question from a list of questions
            currentQuestion = Random.Range(0, QnA.Count);

            QuestionText.text = QnA[currentQuestion].Question;
            SetAnswers();
        }
        else
        {
            Debug.Log("Out of Questions");
            gameOver();
        }
        

        
    }

    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<UnityEngine.UI.Image>().color = options[i].GetComponent<AnswerScript>().startColor;
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];

            if (QnA[currentQuestion].CorrectAnswer == i + 1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
           

        }
    } //end SetAnswers() method

    IEnumerator WaitForNext()
    {
        yield return new WaitForSeconds(1);
        generateQuestion();
    }
    public void correct()
    {

        
        //increase score count
        Score += 1;

        //get rid of the question, so it doesn't repeat 
        QnA.RemoveAt(currentQuestion);

      //  generateQuestion();
        StartCoroutine(WaitForNext());

    }//end correct() method

    public void gameOver()
    {

        //enable the gameOver panel and disable the quiz panel
        Quizpanel.SetActive(false);
        Endpanel.SetActive(true);

       
        ScoreTxt.text = Score + "/" + Total;
      


    }

    //method to reload the game
    public void retry()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void wrong()
    {
        
        QnA.RemoveAt(currentQuestion);
        StartCoroutine(WaitForNext());
    }
}
