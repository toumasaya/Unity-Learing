using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _score;
    private bool _isGetThePoints = true;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _score += 10;
            Debug.Log(_score);
        }

        if (_score >= 50 && _isGetThePoints)
        {
            Debug.Log("Awesome!");
            _isGetThePoints = false;
        }
    }
}
