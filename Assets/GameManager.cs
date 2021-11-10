using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool IsGameOver { get; set; }

    private int _speed;
    public int Speed
    {
        get
        {
            return _speed;
        }
        private set
        {
            _speed = value;
        }
    }
    public string Name { get; set; }

    void Start()
    {
        IsGameOver = false;
        Speed = 100;
        Debug.Log(Speed);
        Name = "Unity";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            IsGameOver = true;
            CheckISGameOver();
        }
    }

    void CheckISGameOver()
    {
        if (IsGameOver == true)
        {
            Debug.Log("Game Over");
        }
    }

}
