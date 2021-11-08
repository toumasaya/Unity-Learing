using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Male : Npc
{
    public int strengthAmout;
    public bool isBad;

    public void Attack()
    {
        Debug.Log("Attack");
    }
}
