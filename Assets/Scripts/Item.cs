using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public string name;
    public float weight;
    public Color color;
    public Sprite sprite;


    public Item()
    {

    }
    public Item(string name, float weight, Color color, Sprite sprite)
    {
        this.name = name;
        this.weight = weight;
        this.color = color;
        this.sprite = sprite;
    }
}
