using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float _moveSpeed;
    void Update()
    {
        transform.Translate(Vector3.up * _moveSpeed * Time.deltaTime);
    }
}
