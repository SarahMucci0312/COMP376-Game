using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PuzzleCounter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;


    void Start()
    {
        
    }

    void Update()
    {
        text.text = ("Puzzles completed: " + StateNameConptroller.solved + "/4");
    }
}
