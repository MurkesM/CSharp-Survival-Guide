using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    string _name = "Ethan";
    int _age = 21;
    float _speed = 10;
    int _health = 3;
    int _score = 1000;
    bool _allKeysCollected = false;
    int _ammo = 20;


    void Start()
    {
        Debug.Log($"My name is: {_name}, My age is: {_age}, My speed is: {_speed}, My Health is: {_health}, My Score is {_score}, My Ammo is: {_ammo}");
        Debug.Log($"I collected all the keys: {_allKeysCollected}");
    }

    void Update()
    {
        
    }
}
