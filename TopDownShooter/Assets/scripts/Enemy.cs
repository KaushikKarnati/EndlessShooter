using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public float speed;
    private Transform playerPos;
    private player pl;

    void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        pl = GameObject.FindGameObjectWithTag("Player").GetComponent<player>();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime); 
        if(pl.health<=0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            pl.health--;
            Debug.Log(pl.health);
            Destroy(this.gameObject);
        }
        if (collision.CompareTag("Bullet"))
            Destroy(gameObject);
    }
}
