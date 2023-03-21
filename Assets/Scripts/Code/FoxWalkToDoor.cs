using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxWalkToDoor : MonoBehaviour
{
    // Start is called before the first frame update
    bool flag1, flag2, flag3, flag4;
    public List<GameObject>  wayPoints;
    public float speed = 2;
    int index = 0;
    void Start()
    {
        flag1 = false;
        flag2 = false;
        flag3 = false;
        flag4 = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        flag1 = FindObjectOfType<Look_horizontally>().isHorizontally;
        flag2 = FindObjectOfType<Touching_Head>().Head_touched;
        flag3 = FindObjectOfType<Open_window>().done;
        flag4 = FindObjectOfType<Feed>().done;

        if (flag1 && flag2 && flag3 && flag4)
        {
            
            Vector3 destination = wayPoints[index].transform.position;
            Vector3 newPos = Vector3.MoveTowards(transform.position, wayPoints[index].transform.position, speed * Time.deltaTime);
            transform.position = newPos;

            float distance = Vector3.Distance(transform.position, destination);
            if(distance <= 0.05)
            {
                index++; 
            }
        }
    }
}
