using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public delegate void OnGameOver();
    public static event OnGameOver GameOver;

    void OnEnable()
    {
        GameOver += StopPlayerInput;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameOver?.Invoke();
        }
    }

    void StopPlayerInput()
    {
        Debug.Log("Stop player input");
    }

    void OnDisable()
    {
        Player.GameOver -= StopPlayerInput;
    }
}
