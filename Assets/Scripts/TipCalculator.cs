using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{
    public float bill;
    public float tip;
    public float total;

    void Start()
    {
        tip = bill * tip;
        total = bill + (tip / 100);

        Debug.Log($"Your bill is: {bill}, your tip is {tip}, and your total is {total}.");
    }

    void Update()
    {
        
    }
}
