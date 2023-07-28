using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    [SerializeField] private GameObject gameObjectPrefab;
    [SerializeField] private int amountToGenerate = 20;

    private List<GameObject> gameObjectPool = new List<GameObject>();

    private GameObject currentGameObject;

    private void Awake()
    {
        gameObjectPool = GenerateGameObjects(amountToGenerate);
    }

    private List<GameObject> GenerateGameObjects(int amountToGenerate)
    {
        for (int i = 0; i < amountToGenerate; i++)
            CreateGameObject(false);
      
        return gameObjectPool;
    }

    private GameObject CreateGameObject(bool setActive)
    {
        //create new gameobject
        currentGameObject = Instantiate(gameObjectPrefab, transform);

        //turn off by default
        currentGameObject.SetActive(setActive);

        //add to list
        gameObjectPool.Add(currentGameObject);

        return currentGameObject;
    }

    /// <summary>
    /// Returns the first active gameobject in the pre-created pool of gameobjects.
    /// </summary>
    public GameObject RequestGameObject()
    {
        //loop through the pool to find and return the first inactive gameobject
        foreach (GameObject gameObject in gameObjectPool)
        {
            if (!gameObject.activeSelf)
            {
                gameObject.SetActive(true);
                return gameObject;
            }
        }

        //if no gameobjects where found, then create another one on the fly and add it to the pool
        return CreateGameObject(true);
    }
}