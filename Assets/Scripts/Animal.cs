using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    private void Start()
    {
        MakeSound();
    }

    public virtual void MakeSound()
    {
        Debug.Log("Animal noise");
    }
}