using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger");
        if (other.tag == "Food")
        {
            /*
            Renderer rend = this.gameObject.GetComponent<Renderer>();
            rend.enabled = true;
            */

        }
        else
        {
            Debug.Log("other");
        }
    }

}
