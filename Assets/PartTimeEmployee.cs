using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartTimeEmployee : Employee
{
    public int hoursWorked;
    public int houlyRate;

    public override void CalculateMonthlySalary()
    {
        throw new System.NotImplementedException();
    }
}
