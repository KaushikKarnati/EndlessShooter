using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet1,bullet2,bullet3;
    int whatBullet;
    private Transform playerPos;

    private void Start()
    {
        playerPos = GetComponent<Transform>();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown((0)))
        {
            whatBullet = Random.Range(0, 4);
            Debug.Log(whatBullet);

            switch (whatBullet)
            {
                case 1:
                    Instantiate(bullet1, playerPos.position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(bullet2, playerPos.position, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(bullet3, playerPos.position, Quaternion.identity);
                    break;
            }
        }
    }
}
