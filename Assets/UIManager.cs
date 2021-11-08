using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text enemySpawnedText;

    public void UpdateEnemyCount()
    {
        enemySpawnedText.text = "Enemy Spwaned Counts: " + SpawnManager.enemyCount;
    }

}
