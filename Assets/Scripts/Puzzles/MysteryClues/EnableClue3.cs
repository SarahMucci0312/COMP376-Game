using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableClue3 : MonoBehaviour
{
    void Update()
    {
        if (StateNameConptroller.p3Correct)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(true);

            }
        }
    }
}
