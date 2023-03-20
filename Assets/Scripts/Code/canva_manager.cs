using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canva_manager : MonoBehaviour
{
    public Transform head;
    public float spawnDis = 2;
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        canvas.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDis;
        canvas.transform.LookAt(new Vector3(head.position.x, canvas.transform.position.y, head.position.z));
        canvas.transform.forward *= -1;
    }
}
