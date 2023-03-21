using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feed : MonoBehaviour
{

    public bool done = false;
    public GameObject fox;
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
            done = true;
            fox.GetComponent<Animator>().Play("eat");

        }
        else
        {
            Debug.Log("other");
        }
    }

}
