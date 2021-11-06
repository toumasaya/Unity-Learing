using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public GameObject cube;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Hi");
            ChangeCubeColor(cube, Color.red);
        }
    }

    void ChangeCubeColor(GameObject obj, Color colorToAssign)
    {
        obj.GetComponent<MeshRenderer>().material.color = colorToAssign;
    }
}
