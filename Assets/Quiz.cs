using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quiz : MonoBehaviour
{
    public int quiz1, quiz2, quiz3, quiz4, quiz5;
    public int average;
    private int _gradeA = 90;
    private int _gradeB = 80;
    private int _gradeC = 70;
    void Start()
    {
        quiz1 = GenerateQuiz(0);
        quiz2 = GenerateQuiz(20);
        quiz3 = GenerateQuiz(40);
        quiz4 = GenerateQuiz(60);
        quiz5 = GenerateQuiz(80);

        average = CalculateAverage(average);

        if (average > _gradeA)
        {
            Debug.Log("A");
        }
        else if (average < _gradeA && average >= _gradeB)
        {
            Debug.Log("B");
        }
        else if (average < _gradeB && average > _gradeC)
        {
            Debug.Log("C");
        }
        else
        {
            Debug.Log("F");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private int GenerateQuiz(int min)
    {
        return Random.Range(min, 101);
    }

    private int CalculateAverage(int average)
    {
        return average = (quiz1 + quiz2 + quiz3 + quiz4 + quiz5) / 5;
    }
}
