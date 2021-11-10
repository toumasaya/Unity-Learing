using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{
    public List<Item> ItemDatabase = new List<Item>();

    public void AddItem(int itemID, Player player)
    {
        // Check id is exsit
        foreach (var item in ItemDatabase)
        {
            if (item.id == itemID)
            {
                Debug.Log("Find the id!");
                player.inventory[itemID] = item;
                return;
            }
        }
        Debug.Log("Item doesn't exsit");
    }

    public void RemoveItem(int itemID, Player player)
    {
        foreach (var item in ItemDatabase)
        {
            if (item.id == itemID)
            {
                Debug.Log("Find the id to removed");
                player.inventory[itemID] = null;
                return;
            }
        }
        Debug.Log("Item doesn't exsit");
    }
}
