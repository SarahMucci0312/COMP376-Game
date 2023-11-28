using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public MyDoorController doorScript;
 
    void Update()
    {


        if (StateNameConptroller.b1 == true && StateNameConptroller.b2 == true && StateNameConptroller.b3 == true && StateNameConptroller.doOnce == false)
        {
            //Debug.Log("door open tru");
            doorScript.doorOpen=true;
            doorScript.PlayAnimation();
            StateNameConptroller.doOnce = true;
            //transform.position = new Vector3(50,0,0);
        }
        
    }
}
