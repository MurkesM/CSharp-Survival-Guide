using System; //needed to use actions
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public Func<int, int, int> Sum;

    void Start()
    {
        Sum = (a, b) => a + b;

        int sum = Sum(1, 10);
        Debug.Log(sum);
    }
}