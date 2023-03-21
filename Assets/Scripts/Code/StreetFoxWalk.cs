using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetFoxWalk : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform wayPoints;
    public float speed = 1.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float cur_distance = Vector3.Distance(transform.position, wayPoints.position);

        if(cur_distance > 4)
        {
            transform.position = Vector3.MoveTowards(transform.position, wayPoints.position, speed * Time.deltaTime);
        }
        //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(wayPoints.position - transform.position), speed * Time.deltaTime);
        transform.LookAt(wayPoints);

        Quaternion rotationAmount = Quaternion.Euler(0, 90, 0);
        Quaternion postRotation = transform.rotation * rotationAmount;

        transform.rotation = postRotation;

        
    }
}
