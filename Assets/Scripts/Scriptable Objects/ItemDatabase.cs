using UnityEngine;

[CreateAssetMenu(fileName = "Item Database", menuName = "ScriptableObjects/ItemDatabase", order = 1)]
public class ItemDatabase : ScriptableObject
{
    public string itemName;
    public int itemID;
    public string itemType;
}