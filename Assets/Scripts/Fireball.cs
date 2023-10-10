using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public int Speed;
    public GameObject player;
    public GameObject projectile;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(projectile, transform.position, transform.rotation);
        }
    }
    /*
        //instantiate fireball 
        Vector3 localPosition = player.transform.position - transform.position;
        transform.Translate(localPosition.x * Time.deltaTime * Speed, localPosition.y * Time.deltaTime * Speed,
            localPosition.z * Time.deltaTime * Speed);
    }
    */
    
    // Start is called before the first frame update
    void Start() 
    {
        Speed = 2;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
} 
