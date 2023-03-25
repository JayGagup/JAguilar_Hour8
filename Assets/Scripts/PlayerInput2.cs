using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.M))
            Debug.Log("The 'M' key is pressed down");
        if (Input.GetKeyDown(KeyCode.O))
            Debug.Log("The 'O' key was pressed");
    }
}
