using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IDamagable
{
    public int Health { get; set; }

    public void DamagePlayer(int damage)
    {
        Health -= damage;
    }
}
