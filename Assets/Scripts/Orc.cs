using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Orc : MonoBehaviour
{
    // Start is called before the first frame update
   
   public float enemyhealth = 2;
   public int speed;
   public GameObject player;
   
   private Vector3 localPosition;
   
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        localPosition = player.transform.position - transform.position;
        speed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 localPosition = player.transform.position - transform.position;
        localPosition = localPosition.normalized;
        transform.Translate(localPosition.x * Time.deltaTime * speed, localPosition.y * Time.deltaTime * speed, localPosition.z * Time.deltaTime * speed);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Fireball"))
        {
            other.gameObject.SetActive(false);
            EnemyLooseHealth();
        }
        
        if (other.gameObject.CompareTag("Spikes"))
        {
            other.gameObject.SetActive(false);
            EnemyLooseHealth();
        }
        
    }

    void EnemyLooseHealth()
    {
        enemyhealth -= 1;
        if (enemyhealth <= 0)
        {
            Defeat();
        }
    }

    void Defeat()
    {
        gameObject.SetActive(false);
    }
}
