using UnityEngine;

public class TestPoolManager : MonoBehaviour
{
    public PoolManager poolManager;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            poolManager.RequestGameObject();
    }
}