using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    
    public string _name;
    public string _description;
    public Sprite _itemSprite;
    public int _dmg;

    void Start()
    {
        Debug.Log($"Item name: {_name}, Item description: {_description}, Item damage: {_dmg}");
    }
}
