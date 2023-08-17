using UnityEngine;

public class Sword : MonoBehaviour
{
    public SwordDatabase swordDatabase;

    public void DoDamage()
    {
        print($"Do {swordDatabase.damage} Damage");
    }
}