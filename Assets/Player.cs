using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string _playerName = "Ben";
    public int _playerAge = 20;
    public int _health = 100;
    public int _score = 0;
    public float _speed = 10f;
    public bool _isKeyCollected;
    public int _ammoCount = 100;

    void Start()
    {
        Debug.Log("Player Name: " + _playerName);
        Debug.Log("Player Age: " + _playerAge);
        Debug.Log("Health: " + _health);
        Debug.Log("Score: " + _score);
        Debug.Log("Speed: " + _speed);
        Debug.Log("Is Key Collected: " + _isKeyCollected);
        Debug.Log("Ammo Count: " + _ammoCount);
    }
}
