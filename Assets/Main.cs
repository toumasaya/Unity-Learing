using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Main : MonoBehaviour
{
    public string[] names = { "Louf", "Mary", "Fan", "Eev", "Piper", "Louf", "Mary" };

    // Start is called before the first frame update
    void Start()
    {
        // === Any
        // var nameFound = names.Any(name => name == "Loufoooo");
        // Debug.Log("Found name: " + nameFound);

        // === Contains
        // var nameFound = names.Contains("Louf");

        // === Distinct
        // var uniqueName = names.Distinct();
        // foreach (var name in uniqueName)
        // {
        //     Debug.Log("Name: " + name);
        // }

        // === Where
        var result = names.Where(name => name.Length > 4);
        foreach (var name in result)
        {
            Debug.Log("Result: " + name);
        }


    }
}
