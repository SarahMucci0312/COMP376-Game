using TMPro;
using UnityEngine;

public class Puzzle1 : MonoBehaviour
{
    public AudioSource incorrectSound;
    public AudioSource doorSound;

    private string input = "Wendy";
    public TMP_InputField userInput;
    
    void Update()
    {
        Cursor.visible = true;
        input = input.ToLower();
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (input.CompareTo(userInput.text.ToLower()) == 0)
            {
                doorSound.Play();
                StateNameConptroller.p1Solved = true;
                StateNameConptroller.p1Correct = true;
                StateNameConptroller.p1Open = false;
                Cursor.visible = false;
                StateNameConptroller.correctlySolved += 1;
                StateNameConptroller.solved += 1;
            }
            else
            {
                incorrectSound.Play();
                StateNameConptroller.p1tries += 1;
            }
        }

        if(StateNameConptroller.p1tries == 3)
        {
            Cursor.visible = false;
            StateNameConptroller.p1Solved = true;
            StateNameConptroller.p1Open = false;
            StateNameConptroller.solved += 1;
        }
    }
}
