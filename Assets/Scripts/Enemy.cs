using UnityEngine;

public class Enemy : MonoBehaviour
{
    void OnEnable()
    {
        Player.GameOver += StopAttacking;
    }

    void StopAttacking()
    {
        Debug.Log("Stop attacking player");
    }

    void OnDisable()
    {
        Player.GameOver -= StopAttacking;
    }
}