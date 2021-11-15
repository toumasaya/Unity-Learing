using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public Func<int> onGetName;
    public Func<int, int, int> onGetSum;

    void Start()
    {
        onGetName = () => this.gameObject.name.Length;
        int count = onGetName();
        Debug.Log(count);

        // onGetSum = (a, b) => a + b;
        onGetSum = (a, b) =>
        {
            int total = a + b;
            Debug.Log("The sum: " + total);
            return total;
        };
        onGetSum(5, 7);

    }

    // int GetNameLength()
    // {
    //     return this.gameObject.name.Length;
    // }

    // int CalculateSum(int a, int b)
    // {
    //     return a + b;
    // }
}
