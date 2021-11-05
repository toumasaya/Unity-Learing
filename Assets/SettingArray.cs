using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingArray : MonoBehaviour
{
    public string[] names;
    public int[] ages;
    public string[] carModels;
    public int index;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetRandomIndex();
            Debug.Log("The kid is " + names[index] + ", age " + ages[index] + ", likes " + carModels[index]);
        }
    }

    void GetRandomIndex()
    {
        index = Random.Range(0, names.Length);
    }
}
