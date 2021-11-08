using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Employee
{
    public int employeeID;
    public string firstName, lastName;
    public int salary;

    public static string company;

    // Static constructor - Run first
    static Employee()
    {
        company = "Maelouf Studio";
        Debug.Log("Initialized Static member");
    }

    // Class constructor - Run second
    public Employee()
    {
        Debug.Log("Initialized Instance member");
    }
}

public class EmployeeTest : MonoBehaviour
{
    void Start()
    {
        Employee e1 = new Employee();
        Employee e2 = new Employee();
        Employee e3 = new Employee();
        Employee e4 = new Employee();
        Employee e5 = new Employee();
    }
}
