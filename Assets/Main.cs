using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MyRoutine(() =>
        {
            Debug.Log("Finish");
        }));
    }

    public IEnumerator MyRoutine(Action onComplete = null)
    {
        yield return new WaitForSeconds(5.0f);

        // Debug.Log("Finish");

        if (onComplete != null)
        {
            onComplete();
        }
    }
}
