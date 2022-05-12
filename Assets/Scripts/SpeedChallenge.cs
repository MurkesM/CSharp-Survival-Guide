using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedChallenge : MonoBehaviour
{
    public float speed = 0;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
            speed += 10;
        else if (Input.GetKeyDown(KeyCode.A) && speed > 0)
            speed -= 10;

        switch (speed)
        {
            case 0:
                Debug.Log("speed = 0");
                break;
            case 10:
                Debug.Log("speed = 10");
                break;
            case 15:
                Debug.Log("speed = 15");
                break;
            case 20:
                Debug.Log("speed = 20");
                break;
            default:
                Debug.Log("??");
                break;
        }
    }
}
