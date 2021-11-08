using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 如果只是使用 4 個以下的欄位，可以使用 struct
// struct 無法被更改，immutable
// struct 無法使用繼承
public struct Item2 // Value type -- stored on a Stack
{
    public string itemName;
    public int itemID;

    public Item2(string itemName, int itemID)
    {
        this.itemName = itemName;
        this.itemID = itemID;
    }
}

public class Item // Reference type -- stored on a Heap
{
    public string itemName;
    public int itemID;

    public Item(string itemName, int itemID)
    {
        this.itemName = itemName;
        this.itemID = itemID;
    }
}


public class Test : MonoBehaviour
{
    Item knife = new Item("Knife", 1);

    // You don't have to create an instance of an object
    // it just automatically exists
    // because it's a value type
    Item2 bread;

    void Start()
    {
        bread.itemName = "Bread";
        bread.itemID = 2;

        //========== Reference type test
        Debug.Log("Knife current name: " + knife.itemName);
        ChangeValue(knife);
        Debug.Log("Knife current name(After method): " + knife.itemName);

        Debug.Log("==================================");

        //========== Value type test
        Debug.Log("Bread current name: " + bread.itemName);
        ChangeValue(bread);
        Debug.Log("Bread current name(After method): " + bread.itemName);
    }

    void ChangeValue(Item2 structItem) // Value type
    {
        structItem.itemName = "Dirty Bread";
        Debug.Log("Bread current name(In the method): " + structItem.itemName);
    }

    void ChangeValue(Item classItem) // Reference type
    {
        classItem.itemName = "Master Knife";
    }
}
