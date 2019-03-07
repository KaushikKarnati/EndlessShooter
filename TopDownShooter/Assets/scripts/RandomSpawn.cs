using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject enemy1, enemy2, enemy3;
    public float spawnRate = 3f;
    public float nextSpawn;
    int whatToSpawn;

    private void Update()
    {
        if(Time.time>nextSpawn)
        {
            whatToSpawn = Random.Range(0, 4);
            Debug.Log(whatToSpawn);

            switch(whatToSpawn)
            {
                case 1:
                    Instantiate(enemy1, transform.position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(enemy2, transform.position, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(enemy3, transform.position, Quaternion.identity);
                    break;
            }

            nextSpawn = Time.time + spawnRate;
        }
    }
}
