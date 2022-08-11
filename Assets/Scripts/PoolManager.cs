using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    private PoolManager _instance;
    public PoolManager Instance
    {
        get
        {
            if (_instance == null)
                Debug.Log("PoolManager is Null");

            return _instance;
        }
    }

    [SerializeField] GameObject _projectilePrefab;
    [SerializeField] int _amountToSpawn;
    [SerializeField] List<GameObject> _projectilePool = new List<GameObject>();
    

    void Awake()
    {
        _instance = this;
    }

    void Start()
    {
      _projectilePool = GenerateBullets();
    }

    List<GameObject> GenerateBullets()
    {
        for (int i = 0; i < _amountToSpawn; i++)
        {
            GameObject projectile = Instantiate(_projectilePrefab, transform.position, Quaternion.identity);
            _projectilePool.Add(projectile);
            //make bullet child of container object
            //set all bullets to false by default
        }
      
        return _projectilePool;
    }
}