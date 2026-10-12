using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputP3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Read mouse movement axes every frame
        float mxVal = Input.GetAxis("Mouse X");
        float myVal = Input.GetAxis("Mouse Y");

        if (mxVal != 0f)
            print("Mouse X movement selected: " + mxVal);
        if (myVal != 0f)
            print("Mouse Y movement selected: " + myVal);
    }
}
