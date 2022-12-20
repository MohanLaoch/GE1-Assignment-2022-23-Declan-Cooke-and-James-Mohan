using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [Header("Spawn Area")]
    public float spawnRange = 10;

    [Header("")]
    public GameObject[] objects;

    public int amount = 50;

    void Start()
    {
        for (int i = 0; i < amount; i++) 
        {
            int randomIndex = Random.Range(0, objects.Length);
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-spawnRange / 2, spawnRange / 2), Random.Range(-spawnRange / 2, spawnRange / 2), Random.Range(-spawnRange / 2, spawnRange / 2));
            GameObject newObj = Instantiate(objects[randomIndex], randomSpawnPosition, Quaternion.Euler(0f, 0f, 0f)); 
        }

    }    
    

    void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireCube(transform.position, new Vector3(spawnRange, spawnRange, spawnRange));
    }
}
