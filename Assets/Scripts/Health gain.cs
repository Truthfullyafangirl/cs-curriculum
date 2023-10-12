using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Healthgain : MonoBehaviour
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
        if (other.gameObject.CompareTag("HealthPotion"))
        {
            GainHealth();
        }
    }
    void GainHealth()
    {
        hud.health += 1;
    }
}
