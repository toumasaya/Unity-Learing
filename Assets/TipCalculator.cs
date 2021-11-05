using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{
    public float _bill = 400;
    public float _tip;
    public int _totalAmount;
    void Start()
    {
        _totalAmount = Mathf.RoundToInt(_bill + _bill * _tip);
        Debug.Log("Your bill is: " + _bill + ", and your tip is: " + _tip * 100 + "% ,so you owe: " + _totalAmount);
    }
}
