using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    public float quizGrade1;
    public float quizGrade2;
    public float quizGrade3;
    public float quizGrade4;
    public float quizGrade5;
    public float quizAverage;

    void Start()
    {
        float randomNumber1 = Random.Range(0, 101);
        float randomNumber2 = Random.Range(0, 101);
        float randomNumber3 = Random.Range(0, 101);
        float randomNumber4 = Random.Range(0, 101);
        float randomNumber5 = Random.Range(0, 101);

        quizGrade1 = 95;
        quizGrade2 = 95;
        quizGrade3 = 95;
        quizGrade4 = 95;
        quizGrade5 = 95;

        quizAverage = (quizGrade1 + quizGrade2 + quizGrade3 + quizGrade4 + quizGrade5) / 5;

        if (quizAverage >= 90)
            Debug.Log("You got an A");
        else if (quizAverage <= 89 && quizAverage >= 80)
            Debug.Log("You got a B");
        else if (quizAverage <= 79 && quizAverage >= 70)
            Debug.Log("You got a C");
        else
        {
            Debug.Log("You got an F");
        }
    }

    void Update()
    {
       
    }
}
