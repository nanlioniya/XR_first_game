using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Look_horizontally : MonoBehaviour
{
    private Vector3 headsetPosition;
    public bool isHorizontally = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InputDevices.GetDeviceAtXRNode(XRNode.Head).TryGetFeatureValue(CommonUsages.centerEyePosition, out headsetPosition);

        if (headsetPosition.y < -0.5f)
        {
            //Debug.Log("Triggered by head position!");
            isHorizontally = true;
        }
        
        else{
            isHorizontally = false;
        }
    }
}
