using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    public int score = 0;
    [SerializeField] GameObject cube;
    MeshRenderer cubeMR;

    public int weapenID;

    void Start()
    {
        cubeMR = cube.GetComponent<MeshRenderer>();
        cubeMR.material.color = Color.red;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
            weapenID = 1;
        if (Input.GetKeyDown(KeyCode.A))
            weapenID = 2;
        if (Input.GetKeyDown(KeyCode.S))
            weapenID = 3;

        switch (weapenID)
        {
            case 1:
                Debug.Log("Gun");
                break;
            case 2:
                Debug.Log("Knife");
                break;
            case 3:
                Debug.Log("Spatula");
                break;
            default:
                Debug.Log("no weapon");
                break;
        }
    }
}
