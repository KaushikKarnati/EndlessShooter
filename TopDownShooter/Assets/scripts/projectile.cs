using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    private Vector2 target;
    public GameObject enemy1, enemy2, enemy3;
    int whatToSpawn;
    public float speed;


    private void Start()
    {
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, target) < 0.2f)
        {
            whatToSpawn = Random.Range(0, 4);
            Debug.Log(whatToSpawn);

            switch (whatToSpawn)
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
            Destroy(gameObject);
        }
        
    }
}
