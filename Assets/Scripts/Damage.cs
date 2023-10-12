using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour
{
    public HUD hud;

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
    void LooseHealth()
    {
        hud.health -= 1;
        if (hud.health <= 0)
        {
            Death();
        }
        Debug.Log("Health: "+hud.health);
    }

    void Death()
    {
        Scene scene = SceneManager.GetActiveScene(); 
        SceneManager.LoadScene(scene.name); 
    }
    
}