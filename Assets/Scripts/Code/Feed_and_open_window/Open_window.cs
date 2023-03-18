using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Open_window : MonoBehaviour
{
    public bool done = false;
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.Two))
        {
            /*
            bool isActive = !gameObject.activeSelf;
            gameObject.SetActive(isActive);
            */
            gameObject.GetComponent<Animator>().Play("Openingwindow");
            done = true;
        }
    }
    // Update is called once per frame
}
