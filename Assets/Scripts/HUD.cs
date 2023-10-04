using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;


public class HUD : MonoBehaviour
{
    public TextMeshProUGUI healthText;

    public TextMeshProUGUI coinsText;
    public Damage health_bar;
    public CollectCoins coin_purse;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: "+health_bar.health;
        coinsText.text = "Coins: "+coin_purse.gold;
    }
}
