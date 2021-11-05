using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    public int speed;
    public int maxSpeed;
    void Start()
    {
        maxSpeed = Random.Range(60, 121);
        StartCoroutine(IncrementSpeed());
    }

    IEnumerator IncrementSpeed()
    {
        // while (true)
        // {
        //     yield return new WaitForSeconds(0.5f);
        //     speed += 5;

        //     if (speed > maxSpeed)
        //     {
        //         break;
        //     }
        // }

        do
        {
            speed += 5;
            yield return new WaitForSeconds(0.5f);
        } while (speed < maxSpeed);
    }
}
