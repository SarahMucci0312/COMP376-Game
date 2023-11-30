using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableGoodEnd : MonoBehaviour
{
    void Update()
    {
        if (StateNameConptroller.correctlySolved == 3)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(true);
            }
        }
    }
}
