using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onplayersfireball : MonoBehaviour
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
        if (other.gameObject.CompareTag("Orc"))
        {
            other.gameObject.GetComponent<Orc>().LooseHealth();
            Destroy(gameObject);
        }
        
        if (other.gameObject.CompareTag("Floor"))
        {
            Destroy(gameObject);
        }
        
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
        
        if (other.gameObject.CompareTag("Moving platforms"))
        {
            Destroy(gameObject);
        }
    }
}
