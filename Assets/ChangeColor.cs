using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public GameObject cube;
    Renderer cubeRenderer;
    public int nextColor;
    void Start()
    {
        cubeRenderer = cube.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            nextColor = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            nextColor = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            nextColor = 3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            nextColor = 4;
        }

        switch (nextColor)
        {
            case 1:
                cubeRenderer.material.color = Color.blue;
                break;
            case 2:
                cubeRenderer.material.color = Color.red;
                break;
            case 3:
                cubeRenderer.material.color = Color.green;
                break;
            case 4:
                cubeRenderer.material.color = Color.black;
                break;
            default:
                cubeRenderer.material.color = Color.yellow;
                break;
        }

        // var inputValue = Input.inputString;

        // switch (inputValue)
        // {
        //     case "1":
        //         cubeRenderer.material.color = Color.blue;
        //         break;
        //     case "2":
        //         cubeRenderer.material.color = Color.red;
        //         break;
        //     case "3":
        //         cubeRenderer.material.color = Color.green;
        //         break;
        //     case "4":
        //         cubeRenderer.material.color = Color.black;
        //         break;
        // }
    }
}
