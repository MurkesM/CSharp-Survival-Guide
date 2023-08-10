using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void Awake()
    {
        Player.OnPlayerSpawned += EnterAttackMode;
    }

    private void OnDestroy()
    {
        Player.OnPlayerSpawned -= EnterAttackMode;
    }

    private void EnterAttackMode()
    {
        Debug.Log("Attack Mode Entered");
    }
}