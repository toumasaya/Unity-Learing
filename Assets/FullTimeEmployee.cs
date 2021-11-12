using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullTimeEmployee : Employee
{
    public int salary;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void CalculateMonthlySalary()
    {
        throw new System.NotImplementedException();
    }
}
