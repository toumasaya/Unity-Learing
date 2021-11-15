using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // public delegate void OnDamageReceived(int currentHealth);
    // public static event OnDamageReceived onDamage;
    public static Action<int> OnDamageRecevied;

    public int Health { get; set; }

    void Start()
    {
        Health = 10;
    }

    void Damage()
    {
        Health--;
        // if (onDamage != null)
        // {
        //     onDamage(Health);
        // }
        if (OnDamageRecevied != null)
        {
            OnDamageRecevied(Health);
        }
    }
}
