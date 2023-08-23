using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRotations : MonoBehaviour
{
    private void Start()
    {
        print($"Euler Angles: {transform.eulerAngles}");
        print($"Quarternion: {transform.rotation}");
    }
}