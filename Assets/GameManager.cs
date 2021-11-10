using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // public List<GameObject> enemiesToSpawn = new List<GameObject>();
    // public GameObject[] objectToSpawn = new GameObject[10];
    public List<string> names = new List<string>();
    void Start()
    {
        Debug.Log("List Count: " + names.Count);
        foreach (var n in names)
        {
            Debug.Log("Name: " + n);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int randomListIndex = Random.Range(0, names.Count);
            // names.RemoveAt(randomListIndex);
            names.Remove(names[randomListIndex]);
            Debug.Log("========================================");
            Debug.Log("Removed index: " + randomListIndex);
            Debug.Log("List Count: " + names.Count);
            foreach (var n in names)
            {
                Debug.Log("Name: " + n);
            }
        }
    }


}
