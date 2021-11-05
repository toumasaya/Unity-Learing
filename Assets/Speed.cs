using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    public float speed;
    void Start()
    {
        speed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            speed += 5;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            speed -= 5;
            if (speed < 0)
            {
                speed = 0;
            }
        }

        if (speed > 20)
        {
            Debug.Log("You need to slow down!");
        }
        else if (speed == 0)
        {
            Debug.Log("You need to speed up!");
        }
    }
}
