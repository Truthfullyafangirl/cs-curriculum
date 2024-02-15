using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movingplatforms : MonoBehaviour
{
    [SerializeField]
    Vector3 point1;
    [SerializeField]
    Vector3 point2;
    [SerializeField]
    Vector3 target;
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        point1 = transform.position;
        target = point1;
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target, step);
        if (Vector3.Distance(transform.position, target) < .1)
        {
            if (target == point1)
            {
                target = point2;
            }
            else
            {
                target = point1;
            }
        }
    }
}
