using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 100;
    public int damageAmount;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isDead() == false)
        {
            Debug.Log("Attack now");
            Attack(10, 50);
        }
    }

    public void Attack(int minDamage, int maxDamage)
    {
        damageAmount = Random.Range(minDamage, maxDamage);
        health -= damageAmount;

        if (isDead())
        {
            health = 0;
            Debug.Log("Player is died");
        }
    }

    public bool isDead()
    {
        return health < 1;
    }
}
