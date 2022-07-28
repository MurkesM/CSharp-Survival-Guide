using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    Item _sword;
    Item _bread;

    void Start()
    {
        _sword = new Item();
        Item.itemCount++;

        _bread = new Item();
        Item.itemCount++;

        _sword.name = "sword";
        _bread.name = "bread";

        
    }

    void Update()
    {
        
    }
}
