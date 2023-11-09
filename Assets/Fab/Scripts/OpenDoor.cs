using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
 
    void Update()
    {


        if (StateNameConptroller.b1 == true && StateNameConptroller.b2 == true && StateNameConptroller.b3 == true)
        {
            transform.position = new Vector3(50,0,0);
        }
        
    }
}
