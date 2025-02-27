using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

using Random = UnityEngine.Random; 

public class Orc : MonoBehaviour
{
    // Start is called before the first frame update
   
   public float enemyhealth = 2;
   public int xspeed;
   public int yspeed;
   public int randomValue;
   GameObject player;
   public bool platformer; 
   
   Animator animator;
   
   public GameObject enemycoindrop;
   public GameObject enemyhealthdrop;
   private Vector3 localPosition;
   
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        animator.enabled = false;
        xspeed = 1;
        yspeed = 1;
        if (platformer)
        {
            yspeed = 0; 
        } 
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            Vector3 localPosition = player.transform.position - transform.position;
            localPosition = localPosition.normalized;
            transform.Translate(localPosition.x * Time.deltaTime * xspeed, localPosition.y * Time.deltaTime * yspeed, localPosition.z * Time.deltaTime * xspeed);
        }
    }
    
        public void LooseHealth()
        {
            enemyhealth -= 1;
            if (enemyhealth <= 0)
            {
                Defeat();
            }
        }

        public void Defeat()
        {
            randomValue = Random.Range(0, 3);
            
            Debug.Log (randomValue); 
            
            if (randomValue == 1)
            {
                Instantiate(enemycoindrop, transform.position, transform.rotation);
            }
            
            else if (randomValue == 2)
            {
                Instantiate(enemyhealthdrop, transform.position, transform.rotation);
            }
            
            gameObject.SetActive(false); 
        }
    
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                player = other.gameObject;
                animator.enabled = true;
            }
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Spikes"))
            {
                other.gameObject.SetActive(false);
                LooseHealth();
            }
           
            if (other.gameObject.CompareTag("Fireball"))
            {
                LooseHealth();
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                animator.enabled = false;
                player = null;
            } 
        }
}