using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamagable
{
    int Health { get; set; }
}

public interface IHealable
{
    int HealthGiven { get; set; }

    void RegenHealth(int health);
}