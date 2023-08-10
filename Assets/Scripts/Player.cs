using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Action OnPlayerSpawned;

    private void OnEnable()
    {
        OnPlayerSpawned?.Invoke();
    }
}