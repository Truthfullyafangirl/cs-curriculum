using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootupgrade : MonoBehaviour
{
    
    
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
        if (other.gameObject.CompareTag("Boot"))
        { 
            //xSpeed = 5; 
            //ySpeed = 5; 
            other.gameObject.SetActive(false);
        }
    }
    
}
