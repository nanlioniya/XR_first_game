using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touching_Head : MonoBehaviour
{
    public bool Head_touched = false;
    private int touch_times = 0;

    // Start is called before the first frame update
    void Start()
    {
        Head_touched = false;
        touch_times = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // Debug.Log("Triggered by: " + other.gameObject.name);
        if (other.CompareTag("Hand"))
        {
            // Debug.Log("Triggerred.");
            if(touch_times++ > 10){
                // Debug.Log("Touch Done!");
                Head_touched = true;
            }
        }
    }

}
