using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 3;
    [SerializeField] private float timeToDisable = 3;

    private void OnEnable()
    {
        transform.position = Vector3.zero;

        Invoke(nameof(DisableProjectile), timeToDisable);
    }

    private void Update()
    {
        transform.Translate(moveSpeed * Time.deltaTime * Vector3.up);
    }
    
    private void DisableProjectile()
    {
        gameObject.SetActive(false);
    }
}