using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    public float speed = 0;
    public float maxSpeed = 50;

    void Start()
    {
        StartCoroutine(SpeedUpRoutine());
    }

    void Update()
    {
        
    }

    IEnumerator SpeedUpRoutine()
    {
        while (speed < maxSpeed)
        {
            speed += 10;
            yield return new WaitForSeconds(1);
        }
    }
}
