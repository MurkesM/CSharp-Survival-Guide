using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float Speed { get; set; } = 5;

    private float dSpeed = 5;

    public string Name1 { get; set; } = "default";

    public float DSpeed
    {
        get
        {
            return dSpeed;
        }
        set
        {
            dSpeed = value;

            Debug.Log("set dspeed");
        }
    }

    void Start()
    {
        Debug.Log(Speed);

        DSpeed = 10;

        Debug.Log(Name1);
        Name1 = "updated";
        Debug.Log(Name1);
    }
}