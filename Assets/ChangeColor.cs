using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public GameObject cube;
    private Renderer _cubeRenderer;
    public int score;
    void Start()
    {
        _cubeRenderer = cube.GetComponent<Renderer>();
        _cubeRenderer.material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            score += 10;
            if (score > 50)
            {
                _cubeRenderer.material.color = Color.green;
            }
        }
    }
}
