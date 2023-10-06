using System.Collections;
using System.Collections.Generic;
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
    
    
    void Start()
    {
        if (Cave)
        {
            ySpeed = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        xDirection = Input.GetAxis("Horizontal");
        xVector = xDirection * xSpeed * Time.deltaTime;
        yDirection = Input.GetAxis("Vertical");
        yVector = yDirection * ySpeed * Time.deltaTime;
        transform.position = transform.position + new Vector3(xVector, yVector, 0);
    }
}
