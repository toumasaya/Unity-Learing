using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Declaring delegate
    // ChangeColor as a type of method
    // Define a signature for delegate
    public delegate void ChangeColor(Color newColor);
    public ChangeColor onColorChange;

    public delegate void OnComplete();
    public OnComplete onComplete;

    // Method Name is whatever
    // The signature -> void MethodName(Color newColor)
    // must be matched
    // This is match delegate void ChangeColor(Color newColor)
    public void UpdateColor(Color newColor)
    {
        Debug.Log("New color: " + newColor.ToString());
    }

    // This match delegate void OnComplete()
    public void Task()
    {
        Debug.Log("Task 1 finished");
    }

    public void Task2()
    {
        Debug.Log("Task 2 finished");
    }

    public void Task3()
    {
        Debug.Log("Task 3 finished");
    }

    private void Start()
    {
        onColorChange = UpdateColor;
        // Invoke like a method
        onColorChange(Color.green);

        // This would be error, it doesn't match onColorChange
        // onColorChange = Task;

        // Basic use
        // onComplete = Task;

        // MultiCast, add method stack
        onComplete += Task;
        onComplete += Task2;
        onComplete += Task3;

        // Remove method stack
        // onComplete -= Task;

        // Invoke like a method
        // Check the onComplete variable is not null,
        // meaning people already rigistered the delegate
        // or it would throw error
        if (onComplete != null)
        {
            onComplete();
        }
    }
}
