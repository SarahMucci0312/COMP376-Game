using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableBadEnd : MonoBehaviour
{
    void Update()
    {
        if (StateNameConptroller.correctlySolved <= 2)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(true);
            }
        }
    }
}
