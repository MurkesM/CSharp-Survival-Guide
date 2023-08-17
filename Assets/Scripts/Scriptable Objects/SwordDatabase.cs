using UnityEngine;

[CreateAssetMenu(fileName = "Sword Database", menuName = "ScriptableObjects/SwordDatabase", order = 1)]
public class SwordDatabase : ItemDatabase
{
    public int damage;
    public int attackSpeed;
}