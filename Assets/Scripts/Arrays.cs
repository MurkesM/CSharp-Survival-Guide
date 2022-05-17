using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public GameObject[] cubes;

    void Start()
    {
      
    }

    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
      {
          for (int i = 0; i < cubes.Length; i++)
          {
              cubes[i].GetComponent<MeshRenderer>().material.color = Color.red;
          }
      }
    }
}
