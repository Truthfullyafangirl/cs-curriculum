using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootupgrade : MonoBehaviour
{

    public Movement player; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        { 
            player.xSpeed = 5; 
            player.ySpeed = 5; 
            gameObject.SetActive(false);
        }
    }
    
}
