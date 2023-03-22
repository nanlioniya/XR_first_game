using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homeBGM : MonoBehaviour
{
    
    public AudioSource _AudioSource1;
    public AudioSource _AudioSource2;
    bool flag1, flag2, flag3, flag4;

    void Start() 
    {

        _AudioSource1.Play();
    
    }
    

    void Update () 
    {
        flag1 = FindObjectOfType<Look_horizontally>().isHorizontally;
        flag2 = FindObjectOfType<Touching_Head>().Head_touched;
        flag3 = FindObjectOfType<Open_window>().done;
        flag4 = FindObjectOfType<Feed>().done;


        if (flag1 && flag2 && flag3 && flag4)
        {

            if (_AudioSource1.isPlaying)
            {

                _AudioSource1.Stop();

                _AudioSource2.Play();

            }

        }
    
    }
 
}

// {
//     public AudioClip bgmClip;
//     public AudioClip forestClip; 
//     public AudioSource bgmSource;

//     public AudioSource bgmForest;

//     bool flag1, flag2, flag3, flag4;

//     // Start is called before the first frame update
//     void Start()
//     {
//         // 播放背景音乐
//         // bgmSource.clip = bgmClip;
//         // bgmSource.loop = true;
//         bgmSource.Play();

//         flag1 = false;
//         flag2 = false;
//         flag3 = false;
//         flag4 = false;
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         flag1 = FindObjectOfType<Look_horizontally>().isHorizontally;
//         flag2 = FindObjectOfType<Touching_Head>().Head_touched;
//         flag3 = FindObjectOfType<Open_window>().done;
//         flag4 = FindObjectOfType<Feed>().done;

//         if (flag1 && flag2 && flag3 && flag4) {
//             // bgmSource.clip = forestClip;
//             // bgmSource.loop = true;
//             bgmForest.Play();
//         }
//     }
// }