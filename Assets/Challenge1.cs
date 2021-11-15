using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable]
public class Item
{
    public string name;
    public int itemID;
    public int buff;
}

public class Challenge1 : MonoBehaviour
{
    public List<Item> items;

    void Start()
    {
        var itemFound = items.Any(item => item.itemID == 3);
        Debug.Log("Item 3 exist ? => " + itemFound);

        var allBuff = items.Where(item => item.buff > 20);
        foreach (var item in allBuff)
        {
            Debug.Log("Buff greater than 20: " + item.name);
        }

        var averageResult = items.Average(item => item.buff);
        Debug.Log("Average: " + averageResult);
    }


}
