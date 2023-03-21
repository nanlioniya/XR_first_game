using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touching_Head : MonoBehaviour
{
    public bool Head_touched = false;
    public AudioClip wtf;

    private int touch_times = 0;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        Head_touched = false;
        touch_times = 0;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
         Debug.Log("Triggered by: " + other.gameObject.name);
        if (other.CompareTag("Hand"))
        {
            // Debug.Log("Triggerred.");
            if(touch_times++ > 5){
                // Debug.Log("Touch Done!");
                Head_touched = true;
            }
            if(Head_touched && touch_times % 5 == 0)
            {
                audioSource.clip = wtf;
                audioSource.Play();

                Debug.Log("wtf wtf wtf wtf.");
            }
        }
    }

}
