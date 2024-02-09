using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UIElements;

public class Lever : MonoBehaviour
{
    
    public GameObject door;

    private bool closed = true;
    
    // Start is called before the first frame update
    void Start()
    {
        //GameObject door = GameObject.FindWithTag("Door");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerStay2D(Collider2D other)
    {
        print("triggered");
        if (other.gameObject.CompareTag("Player") && closed )
        {
            Open();
        }
    }

    void Open()
    {
        print("Open");
        transform.localScale=new Vector3(-1.5f, 1.5f, 1.5f);
        door.SetActive(false);
        closed = false; 
    }
    
}
