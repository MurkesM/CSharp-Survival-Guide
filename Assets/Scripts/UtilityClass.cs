using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UtilityClass
{
    public static void ChangeColor(GameObject gameObject)
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
    }
}
