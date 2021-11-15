using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Quiz : MonoBehaviour
{
    public int[] quizGrades = { 45, 68, 72, 21, 98, 77, 85, 59, 84 };
    // public int[] quizGrades = new int[10];
    // Start is called before the first frame update
    void Start()
    {
        // GenerateQuizGeades();

        var result = quizGrades.Where(q => q > 69).OrderByDescending(g => g).Reverse();
        foreach (var q in result)
        {
            Debug.Log("Above 69: " + q);
        }
    }

    // public void GenerateQuizGeades()
    // {
    //     for (int i = 0; i < quizGrades.Length; i++)
    //     {
    //         quizGrades[i] = Random.Range(50, 100);
    //     }
    // }
}
