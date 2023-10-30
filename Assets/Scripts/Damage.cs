using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour
{
    public HUD hud;

    private float fireballdestroy = 4;
    
    // Start is called before the first frame update
    void Start()
    {
        hud = GameObject.FindObjectOfType<HUD>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Spikes"))
        {
            LooseHealth();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Fireball"))
        {
            other.gameObject.SetActive(false);
            LooseHealth();
        }
        else
        {
            fireballdestroy -= Time.deltaTime;
            if (fireballdestroy < 0)
            {
                other.gameObject.SetActive(false);
                fireballdestroy = 4;
            }
        }
    }

    void LooseHealth()
    {
        Coinloss();
        hud.health -= 1;
        if (hud.health <= 0)
        {
            Death();
        }
    }

    void Death()
    {
        Scene scene = SceneManager.GetActiveScene(); 
        SceneManager.LoadScene(scene.name); 
    }
    
    void Coinloss() 
    {
        if (hud.gold > 5)
        {
            hud.gold -= 1;
        }
    }
    
}


   