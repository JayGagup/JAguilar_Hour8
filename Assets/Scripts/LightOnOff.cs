using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOnOff : MonoBehaviour
{
    Light lightComponent;
     
  
    
        // Start is called before the first frame update
    void Start()
    {
        lightComponent = GetComponent<Light>();
        lightComponent.type = LightType.Point;
      

        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.L))
            lightComponent.enabled = !lightComponent.enabled;
          
    }
}
