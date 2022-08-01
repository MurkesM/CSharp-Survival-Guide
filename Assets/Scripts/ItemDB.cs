using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{
    public List<Item> items = new List<Item>();

    public Dictionary<int, Item> itemDictionary = new Dictionary<int, Item>();

    void Start()
    {
        itemDictionary.Add(0, items[0]); //adding sword to dictionary
        itemDictionary.Add(1, items[1]); //adding axe to dictionary
        itemDictionary.Add(2, items[2]); //adding apple to dictionary

        foreach (int key in itemDictionary.Keys)
        {
            Debug.Log(key);
        }
    }
}