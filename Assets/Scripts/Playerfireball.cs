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
    
    public bool Cave;
    
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
            if (!Cave)
            {
                if (firerate < 0)
                {
                    //set to default fire position
                    Vector2 FirePosition = transform.position;
                    Target = FirePosition;

                    switch (Player.facing)
                    {
                        case "up":
                            FirePosition += Vector2.up * 0.75f; // Adjust offset as needed
                            break;
                        case "down":
                            FirePosition += Vector2.down * 0.75f;
                            break;
                        case "right":
                            FirePosition += Vector2.right * 0.75f;
                            break;
                        case "left":
                            FirePosition += Vector2.left * 0.75f;
                            break;
                    }

                    var fireball = Instantiate(projectile, FirePosition, transform.rotation);
                    Rigidbody2D rb = fireball.GetComponent<Rigidbody2D>();
                    if (Player.facing == "up")
                    {
                        rb.AddForce(Vector2.up * speed, ForceMode2D.Impulse);
                    }

                    else if (Player.facing == "down")
                    {
                        rb.AddForce(Vector2.down * speed, ForceMode2D.Impulse);
                    }

                    else if (Player.facing == "right")
                    {
                        rb.AddForce(Vector2.right * speed, ForceMode2D.Impulse);
                    }

                    else if (Player.facing == "left")
                    {
                        rb.AddForce(Vector2.left * speed, ForceMode2D.Impulse);
                    }

                    firerate = 1;
                }
            }

            /* if (Cave)
            {
                if (firerate < 0)
                {
                    //set to default fire position
                    Vector2 FirePosition = transform.position;
                    Target = FirePosition;

                    switch (Player.facing)
                    {
                        case "right":
                            FirePosition += Vector2.right * 0.75f;
                            break;
                        case "left":
                            FirePosition += Vector2.left * 0.75f;
                            break;
                    }

                    var fireball = Instantiate(projectile, FirePosition, transform.rotation);
                    Rigidbody2D rb = fireball.GetComponent<Rigidbody2D>();

                    if (Player.facing == "right")
                    {
                        rb.AddForce(Vector2.right * speed, ForceMode2D.Impulse);
                    }

                    else if (Player.facing == "left")
                    {
                        rb.AddForce(Vector2.left * speed, ForceMode2D.Impulse);
                    }

                    firerate = 1;
                }
            }*/
        }
    }
}
