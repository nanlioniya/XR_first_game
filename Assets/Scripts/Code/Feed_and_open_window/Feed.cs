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
    
    private IEnumerator PlayEatAnimation()
    {
        // 播放 "eat" 動畫
        fox.GetComponent<Animator>().Play("eat");

        // 等待動畫的播放完成
        yield return new WaitForSeconds(fox.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);

        // 設定 done 為 true
        done = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Food")
        {
            StartCoroutine(PlayEatAnimation());
        }
    }
    // private void OnTriggerEnter(Collider other)
    // {
    //     Debug.Log("trigger");
    //     if (other.tag == "Food")
    //     {
    //         /*
    //         Renderer rend = this.gameObject.GetComponent<Renderer>();
    //         rend.enabled = true;
    //         */
            
    //         fox.GetComponent<Animator>().Play("eat");
    //         done = true;
    //     }
    //     else
    //     {
    //         Debug.Log("other");
    //     }
    // }

}
