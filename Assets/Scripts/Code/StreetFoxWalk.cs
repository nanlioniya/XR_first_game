using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetFoxWalk : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform wayPoints;
    public bool flag = false;
    public float speed = 1.5f;
    public bool enter = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float cur_distance = Vector3.Distance(transform.position, wayPoints.position);

        if(cur_distance > 2)
        {
            gameObject.GetComponent<Animator>().enabled = true;
            gameObject.GetComponent<Animator>().Play("walk");
            transform.position = Vector3.MoveTowards(transform.position, wayPoints.position, speed * Time.deltaTime);
        }
        else{
            if(enter){
                gameObject.GetComponent<Animator>().Play("die");
            }
            else{
                gameObject.GetComponent<Animator>().Play("idle");
            }
            
            //gameObject.GetComponent<Animator>().Play("leg");

        }
        //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(wayPoints.position - transform.position), speed * Time.deltaTime);
        transform.LookAt(wayPoints);

        Quaternion rotationAmount = Quaternion.Euler(0, 90, 0);
        Quaternion postRotation = transform.rotation * rotationAmount;

        transform.rotation = postRotation;

        
    }

        private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            enter = true;

        }
    }
}
