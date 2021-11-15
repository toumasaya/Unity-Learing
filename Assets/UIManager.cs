using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private void OnEnable()
    {
        // Player.onDamage += UpdateHealth;
        Player.OnDamageRecevied += UpdateHealth;
    }
    public void UpdateHealth(int health)
    {
        // Display updated health
        Debug.Log("Current Health: " + health);
    }
}
