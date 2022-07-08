using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineSection : MonoBehaviour
{
    [SerializeField] MeshRenderer _meshRenderer;

    void Start()
    {
        StartCoroutine(ChangeColorRoutine());
        Debug.Log("Testing Coroutines");
    }

    void Update()
    {
        
    }

    IEnumerator ChangeColorRoutine()
    {
         yield return new WaitForSeconds(3);
        _meshRenderer.material.color = Color.red;
    }
}
