using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameItem
{
    public string name;
    public int itemID;
    // public Sprite icon;

    public GameItem() { }
    public GameItem(string name, int itemID)
    {
        this.name = name;
        this.itemID = itemID;
        // this.icon = icon;
    }
}
