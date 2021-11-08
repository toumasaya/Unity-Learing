using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Npc
{
    public string npcName;
    public int npcID;
    public string description;

    // public Npc(string npcName, int npcID, string description)
    // {
    //     this.npcName = npcName;
    //     this.npcID = npcID;
    //     this.description = description;
    // }

    public void Speak()
    {
        Debug.Log("Hi, I'm " + npcName);
    }
}
