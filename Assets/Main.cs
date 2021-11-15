using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public Action<int, int> Sum;
    public Action OnGetName;

    void Start()
    {
        // === Normal way
        // Sum = CalculateSum;

        // === Lambda
        Sum = (a, b) =>
        {
            var total = a + b;

            if (total < 100)
            {
                Debug.Log("Total is less then 100");
            }
            Debug.Log(total);
        };

        Sum(5, 2);

        OnGetName = () => Debug.Log("The name: " + gameObject.name);
        OnGetName();

    }

    // === Normal way
    // void CalculateSum(int a, int b)
    // {
    //     var total = a + b;
    //     Debug.Log(total);
    // }

    // === Normal way
    // void GetObjectName()
    // {
    //     Debug.Log("The name: " + gameObject.name);
    // }
}
