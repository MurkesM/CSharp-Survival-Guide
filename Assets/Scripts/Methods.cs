using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods : MonoBehaviour
{
     public Vector3[] positions;
    int randomIndex;

    void Start()
    {
     
    }
    void Update()
    {
        randomIndex = RandomIndex();
        TransformChange();
    }

    int RandomIndex()
    {
        return Random.Range(0, positions.Length);
    }

    void TransformChange()
    {
        transform.position = positions[randomIndex];
    }
}