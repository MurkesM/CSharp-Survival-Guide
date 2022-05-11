using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizCalculator : MonoBehaviour
{
    public float quizGrade1;
    public float quizGrade2;
    public float quizGrade3;
    public float quizGrade4;
    public float quizGrade5;

    void Start()
    {
        float randomNumber1 = Random.Range(0, 101);
        float randomNumber2 = Random.Range(0, 101);
        float randomNumber3 = Random.Range(0, 101);
        float randomNumber4 = Random.Range(0, 101);
        float randomNumber5 = Random.Range(0, 101);
       
        quizGrade1 = randomNumber1;
        quizGrade2 = randomNumber2;
        quizGrade3 = randomNumber3;
        quizGrade4 = randomNumber4;
        quizGrade5 = randomNumber5;

        float quizAverage = (quizGrade1 + quizGrade2 + quizGrade3 + quizGrade4 + quizGrade5) / 5;

        Debug.Log($"Average grade: {quizAverage}%");
    }
}
