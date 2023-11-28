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
    public Movement Player;
    private Vector3 Target;
    private float firerate = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<Movement>();
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        firerate -= Time.deltaTime;
        
        if (Input.GetKeyDown("space"))
        {
            if (firerate < 0)
            {
                //set to default fire position
                Vector2 FirePosition = transform.position;
                
                if (Player.facing == "up")
                { 
                    FirePosition.y += 1;
                    Target = FirePosition;
                    Target.y += 50;
                    //transform.Translate(localPosition.x * Time.deltaTime * speed,
                    //  localPosition.y * Time.deltaTime * speed);
                }
                
                else if (Player.facing == "down")
                {
                    FirePosition.y += 1;
                    Target = FirePosition;
                    Target.y += 50;
                }
                
                else if (Player.facing == "right")
                {
                    FirePosition.y += 1;
                    Target = FirePosition;
                    Target.y += 50;
                }
                
                else if (Player.facing == "left")
                {
                    FirePosition.y += 1;
                    Target = FirePosition;
                    Target.y += 50;
                }
                
                
                var fireball = Instantiate(projectile, FirePosition, transform.rotation);
                fireball.transform.position += (Target* speed*Time.deltaTime);
                firerate = 1;
            }
        }
    }
    
  
    
}
