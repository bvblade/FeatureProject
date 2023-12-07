using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnEnemy", 5f, 5f);
    }

    void spawnEnemy()
    {
        Instantiate(enemy, transform.position, Quaternion.identity);
    }
}
