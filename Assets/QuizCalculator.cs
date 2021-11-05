using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizCalculator : MonoBehaviour
{
    public float quiz1, quiz2, quiz3, quiz4, quiz5;
    public float average;

    void Start()
    {
        quiz1 = Random.Range(0.0f, 5.0f);
        quiz2 = Random.Range(0.0f, 5.0f);
        quiz3 = Random.Range(0.0f, 5.0f);
        quiz4 = Random.Range(0.0f, 5.0f);
        quiz5 = Random.Range(0.0f, 5.0f);

        average = (quiz1 + quiz2 + quiz3 + quiz4 + quiz5) / 5;
        average = Mathf.Round(average * 100f) / 100f;
        Debug.Log(average);
    }

}
