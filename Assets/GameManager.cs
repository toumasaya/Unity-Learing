using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void OnEnable()
    {
        Player.onDeath += ResetPlayer;
    }

    public void ResetPlayer()
    {
        Debug.Log("Reset Player");
    }
}
