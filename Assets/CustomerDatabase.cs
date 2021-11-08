using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerDatabase : MonoBehaviour
{
    [SerializeField] Customer[] customers;
    void Start()
    {
        foreach (var c in customers)
        {
            Debug.Log(c.firstName + " " + c.lastName + "/" + c.age + "/" + c.grnder + "/" + c.occupation);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
