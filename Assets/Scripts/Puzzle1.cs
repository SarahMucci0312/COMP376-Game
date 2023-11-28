using TMPro;
using UnityEngine;

public class Puzzle1 : MonoBehaviour
{
    public AudioSource correctSound;
    public AudioSource incorrectSound;
    
    private string input = "correct";
    public TMP_InputField userInput;
    
    void Update()
    {
        if(input.CompareTo(userInput.text) == 0)
        {
            correctSound.Play();
            StateNameConptroller.p1Solved = true;
        }
        else if (userInput.text.Length == 8)
        {
            incorrectSound.Play();
        }
    }
}
