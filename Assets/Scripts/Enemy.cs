using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour, IDamagable, IHealable
{
    public int Health { get; set; }
    public int HealthGiven { get; set; }

    public void DamagePlayer(int damage)
    {
        Debug.Log("Damage Player");
    }

    public void RegenHealth(int health)
    {
        Debug.Log("Heal");
    }
}