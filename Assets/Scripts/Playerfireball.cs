using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.tvOS;

public class Playerfireball : MonoBehaviour
{
    
    public int speed;
    private Vector3 localPosition;
    public GameObject projectile;
    public GameObject Player; 
    private float firerate = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Player.GetComponent<Movement>().facing == "up")
            {
                firerate -= Time.deltaTime;
                if (firerate < 0)
                {
                    Vector2 FirePosition = transform.position;
                    FirePosition.y += 1;
                    Debug.Log(FirePosition);
                    Instantiate(projectile, FirePosition, transform.rotation);
                    transform.Translate(localPosition.x * Time.deltaTime * speed,
                        localPosition.y * Time.deltaTime * speed,
                        localPosition.z * Time.deltaTime * speed);
                    
                    firerate = 2;
                }
            }
            
            else if (Player.GetComponent<Movement>().facing == "down")
            {

            }
            
        }
    }
    
  
    
}
