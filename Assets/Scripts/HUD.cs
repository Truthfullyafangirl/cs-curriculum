using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;


public class HUD : MonoBehaviour
{
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI coinsText;
    
    
    public static HUD hud;
    public int gold;
    public int health;

    private void Awake()
    {
        if (hud != null && hud != this)
        {
            Destroy(gameObject);
        } else
        {
            hud = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: "+hud.health;
        coinsText.text = "Coins: "+hud.gold;
    }
}
