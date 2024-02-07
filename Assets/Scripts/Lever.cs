using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Lever : MonoBehaviour
{
    
    GameObject door;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject door = GameObject.FindWithTag("Door");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerStay2D(Collider2D other)
    {
        print("triggered");
        if (other.gameObject.CompareTag("Player")) && Input.GetKeyDown(KeyCode.Q))
        {
            Open();
        }
    }

    void Open()
    {
        print("Open");
        door.SetActive(false);
    }
    
}
