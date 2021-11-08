using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public string name;
    public int itemID;
    public string description;

    public Item(string name, int itemID, string description)
    {
        this.name = name;
        this.itemID = itemID;
        this.description = description;
    }
}
