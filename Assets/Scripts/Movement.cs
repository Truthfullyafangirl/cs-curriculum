using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    private float xDirection;
    private float xVector;
    private float yDirection;
    private float yVector;
    public int xSpeed;
    public int ySpeed;
    public bool Cave;
    
    public string facing = "up";

    public bool grounded;
    private float jumpForce = 350;
    public bool Platformer; 

    void Start()
    {
        if (Cave) 
        {
            ySpeed = 0;
        }
        else if (Platformer) 
        {
            ySpeed = 0;
        }
        else grounded = false;
    }

    // Update is called once per frame
    void Update()
    {
       
        xDirection = Input.GetAxis("Horizontal");
        xVector = xDirection * xSpeed * Time.deltaTime;
        yDirection = Input.GetAxis("Vertical");
        yVector = yDirection * ySpeed * Time.deltaTime;
        transform.position = transform.position + new Vector3(xVector, yVector, 0);


        if (Input.GetAxis("Horizontal") > 0)
        {
            facing = "right";
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            facing = "left";
        }

        if (Input.GetAxis("Vertical") > 0)
        {
            facing = "up";
        }

        if (Input.GetAxis("Vertical") < 0)
        {
            facing = "down";
        }
        
        
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce); 
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor")) 
        {
            grounded = true;
        }
        
        if (collision.gameObject.CompareTag("Enemy")) 
        {
            grounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            grounded = false;
        }
        
        if (collision.gameObject.CompareTag("Enemy")) 
        {
            grounded = true;
        }
    }
}
