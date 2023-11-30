using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableTrueEnd : MonoBehaviour
{
    void Update()
    {
        if (StateNameConptroller.p1Correct && StateNameConptroller.p2Correct && StateNameConptroller.p3Correct && StateNameConptroller.p4Correct)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(true);
            }
        }
    }
}
