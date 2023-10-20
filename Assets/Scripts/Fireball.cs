using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public int speed;
    public GameObject player;
    public Animator animator; 
    
    private Vector3 localPosition;
    
    // Start is called before the first frame update
    void Start() 
    {
        player = GameObject.FindGameObjectWithTag("Player");
        localPosition = player.transform.position - transform.position;
        speed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(localPosition.x * Time.deltaTime * speed, localPosition.y * Time.deltaTime * speed, localPosition.z * Time.deltaTime * speed);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(animator);
        }
    }
} 
