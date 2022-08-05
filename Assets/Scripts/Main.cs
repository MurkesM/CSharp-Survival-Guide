using System; 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Main : MonoBehaviour
{
    [SerializeField] List<Item> _items;

    int[] possibleGrades = { 30, 94, 62, 73, 100, 22, 70};

    void Start()
    {
        var gradeAverage = possibleGrades.Average(grade => grade);

        Debug.Log(gradeAverage);
    }       
}