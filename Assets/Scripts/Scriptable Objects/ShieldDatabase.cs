using UnityEngine;

[CreateAssetMenu(fileName = "Shield Database", menuName = "ScriptableObjects/ShieldDatabase", order = 1)]
public class ShieldDatabase : ItemDatabase
{
    public int durability;
    public int weight;
}