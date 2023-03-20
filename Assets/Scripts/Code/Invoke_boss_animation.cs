using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke_boss_animation : MonoBehaviour
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
        if (other.CompareTag("Player"))
        {
                GameObject boss;
                boss = GameObject.Find("Boss");
                boss.GetComponent<Animator>().Play("defeated");
        }
    }

}
