using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Lever : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Lever"))
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Open();
            }
        }
    }

    void Open()
    {
        GameObject myObject = GameObject.Find("Pixel door");
        myObject.SetActive(false);
    }
    
}
