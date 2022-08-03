using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example2 : MonoBehaviour
{
    void OnEnable()
    {
        
    }

    void OnDisable()
    {
        Example.example1 -= Example2Test;
    }

    void Example2Test()
    {
        Debug.Log("test");
    }
}