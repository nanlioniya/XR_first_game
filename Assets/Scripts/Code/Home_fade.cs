using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Home_fade : MonoBehaviour
{
    // Start is called before the first frame update
    public FaderScreen fadeScreen;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        if(other.tag == "Player"){
            StartCoroutine(GoToSceneRoutine());
            
        }
    }

    IEnumerator GoToSceneRoutine()
    {
        fadeScreen.FadeOut();
        yield return new WaitForSeconds(fadeScreen.fadeDuration);
    }
}
