using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public List<GameObject> listTest = new List<GameObject>();
    public GameObject[] arrayTest= new GameObject[10];
    
    [SerializeField] GameObject cube;
    [SerializeField] GameObject sphere;
    [SerializeField] GameObject capsule;
    [SerializeField] Material _material;

    public List<GameObject> spawnedObjects = new List<GameObject>();

    int randomObj;
    int x;
    int y;
    Vector3 randomPosition;

    void Start()
    {
        listTest.Add(cube);
        listTest.Add(sphere);
        listTest.Add(capsule);

        _material.color = Color.white;

        int example1 = arrayTest.Length;
        int example2 = listTest.Count;

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && spawnedObjects.Count < 10)
        {
            randomObj = Random.Range(0, listTest.Count);

            x = Random.Range(-10, 10);
            y = Random.Range(-10, 10);
            randomPosition = new Vector3(x, y, 0);

            GameObject spawnedObj = Instantiate(listTest[randomObj], randomPosition, Quaternion.identity);

            spawnedObjects.Add(spawnedObj);
        }
        else if (Input.GetKeyDown(KeyCode.Space) && spawnedObjects.Count >= 10)
        {
            foreach (GameObject obj in listTest)
            {
                obj.GetComponent<MeshRenderer>().sharedMaterial.color = Color.green;
                spawnedObjects.Clear();
            }
        }
    }
}