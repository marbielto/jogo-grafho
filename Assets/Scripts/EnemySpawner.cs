using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public float spawnRate;

    private float nextSpawn = 0f;

    void FixedUpdate()
    {
        if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;

            Instantiate(enemy, transform.position, enemy.transform.rotation);
        }
    }
}
