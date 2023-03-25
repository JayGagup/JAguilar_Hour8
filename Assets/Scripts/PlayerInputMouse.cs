using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mxVal = Input.GetAxis("Mouse X");
        float myVal = Input.GetAxis("Mouse Y");
        if (mxVal != 0)
            Debug.Log("Mouse X Movement selected:" + mxVal);
        if (myVal != 0)
            Debug.Log("Mouse Y Movement selected:" + myVal);
    }
}
