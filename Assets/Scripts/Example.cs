using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    public delegate void DelegateExample();
    public static event DelegateExample example1;

    private void Start() 
    {
        example1 += TestMethod1;
        example1 += TestMethod2;
        example1 += TestMethod3;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            example1?.Invoke(); //calls delegate
        }
    }

    void TestMethod1()
    {
        Debug.Log("Test1");
    }
    void TestMethod2()
    {
        Debug.Log("Test2");
    }
    void TestMethod3()
    {
        Debug.Log("Test3");
    }
}
