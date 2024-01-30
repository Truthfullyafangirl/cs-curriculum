using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityRandom = UnityEngine.Random;

public class Orcdrop : MonoBehaviour
{
    int randomNumber;
    
    GameObject coinPrefab;
    GameObject healthPotionPrefab;
    
    void Start()
    {
        GetComponent<Orc>();
        randomNumber = 0;
        
        coinPrefab = GameObject.FindGameObjectWithTag("Coin");
        healthPotionPrefab = GameObject.FindGameObjectWithTag("HealthPotion");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Defeat() 
    {
        randomNumber = UnityEngine.Random.Range(0, 3);

        if (randomNumber == 1)
        {
            Instantiate(coinPrefab, transform.position, transform.rotation);
        }
        
        else if (randomNumber == 2)
        {
            Instantiate(healthPotionPrefab, transform.position, transform.rotation);
        }
    }
}
