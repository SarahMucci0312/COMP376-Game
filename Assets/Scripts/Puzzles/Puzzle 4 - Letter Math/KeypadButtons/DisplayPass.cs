using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DisplayPass : MonoBehaviour
{
    [SerializeField] TextMeshPro text;


    void Start()
    {
        text = GetComponent<TextMeshPro>();
    }


    void Update()
    {
        text.text = StateNameConptroller.currentPass;

        if (StateNameConptroller.currentPass.Length == 4)
        {
            if (StateNameConptroller.currentPass == StateNameConptroller.pass)
            {
                StateNameConptroller.p4Solved = true;
                StateNameConptroller.p4Correct = true;
            }

            else
            {
                StateNameConptroller.currentPass = "";
                StateNameConptroller.p4tries += 1;

                if (StateNameConptroller.p4tries >= 3)
                {
                    StateNameConptroller.p4Solved = true;
                }
            }
        }
    }
}
