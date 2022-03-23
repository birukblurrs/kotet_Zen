using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallCameraSwitch : MonoBehaviour
{
    public Camera SmallCam;
    bool camOn;
    // Start is called before the first frame update
    void Start()
    {
        camOn=true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.H)){
            camOn=false;
        }
         if(Input.GetKeyDown(KeyCode.B)){
            camOn=true;
        }

        if(camOn==false){
            SmallCam.enabled=false;
        }
        else{SmallCam.enabled=true;}
    }
}
