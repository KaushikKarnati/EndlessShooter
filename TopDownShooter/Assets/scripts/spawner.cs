using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject Enemy;
    public Transform[] spawnpoints;
    private float timeBetweenSpawns;
    public float startTime;

    private void Start()
    {
        timeBetweenSpawns = startTime;
    }

    private void Update()
    {
        if(timeBetweenSpawns<=0)
        {
            int randomPos = Random.Range(0, spawnpoints.Length);
            Instantiate(Enemy, spawnpoints[randomPos].position, Quaternion.identity);
            timeBetweenSpawns -= Time.deltaTime;
        }
        else
        {
            timeBetweenSpawns -= Time.deltaTime;
        }
    }

}
