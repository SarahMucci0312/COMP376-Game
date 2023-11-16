using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class SimonSays : MonoBehaviour
{
    int level = 0;
    int buttonClicks = 0;
    int colorOrderRunCount = 0;
    bool correct = false; 
    bool win = false;
    int strikes = 0; 

    [SerializeField] GameObject[] Buttons; 
    [SerializeField] GameObject[] LevelLights; 
    [SerializeField] GameObject[] ChanceLights;
    [SerializeField] int[] ColorOrder; 
    [SerializeField] GameObject Panel;

    // Red (0), yellow (1), green (2), blue (3)
    Color32[] ButtonColors = { new Color32(255, 149, 146, 255), new Color32(255, 251, 91, 255), new Color32(117, 255, 125, 255), new Color32(136, 178, 255, 255) };
    Color32[] ButtonColorsFlash = { new Color32(255, 64, 57, 255), new Color32(255, 185, 0, 255), new Color32(26, 207,36, 255), new Color32(90, 149, 255, 255) };
    //Color32[] ButtonColors = { new Color32(255, 64, 57, 255), new Color32(255, 214, 0, 255), new Color32(0, 255, 51, 255), new Color32(90, 149, 255, 255) };
    //Color32[] ButtonColorsFlash = { new Color32(214, 38, 31, 255), new Color32(255, 182, 0, 255), new Color32(0, 222, 45, 255), new Color32(41, 114, 245, 255) };
    Color white = Color.white;
    Color green = Color.green;
    Color red = Color.red; 
    Color transparent = new Color(0, 0, 0, 0); 

    void Start()
    {
        level = 0;
        buttonClicks = 0;
        win = false;
        colorOrderRunCount = -1;

        // Create a random color order
        for (int i = 0; i < ColorOrder.Length; i++)
        {
            ColorOrder[i] = (Random.Range(0, 4));
            Debug.Log("Order: " + ColorOrder[i]);
        }

        level = 1;
        StartCoroutine(DisplaySequence()); 
    }

    // Flash the correct sequence 
    IEnumerator DisplaySequence()
    {
        buttonClicks = 0;
        colorOrderRunCount++;
        Debug.Log("Wait!"); 
        yield return new WaitForSeconds(2.5f);
        Debug.Log("Go!");
        
        // Loop through the color sequence and flash each color
        for (int i = 0; i <= colorOrderRunCount; i++)
        {
            if (level >= colorOrderRunCount)
            {
                Debug.Log("Flash: " + i); 
                yield return new WaitForSeconds(0.75f);
                Buttons[ColorOrder[i]].GetComponent<Image>().color = ButtonColorsFlash[ColorOrder[i]];
                yield return new WaitForSeconds(1f);
                Buttons[ColorOrder[i]].GetComponent<Image>().color = ButtonColors[ColorOrder[i]];
            }
        }
    }

    // Check if correct button is pressed
    public void ButtonClickVerifier(int button) 
    {
        buttonClicks++;
        if (button == ColorOrder[buttonClicks - 1])
        {
            Debug.Log("Correct button");
            correct = true; 
        } else
        {
            Debug.Log("Incorrect button"); 
            correct = false;
            StartCoroutine(ColorBlink(red));
            ChanceLights[strikes].GetComponent<Image>().color = red;
            
            // Reset values
            colorOrderRunCount = -1;
            strikes++;
            level = 1;

            if (strikes == 3)
            {
                Panel.SetActive(false);
            } else
            {
                StartCoroutine(DisplaySequence());
            }

        }

        // If succeeded current sequence, continue to next sequence
        if (buttonClicks == level && correct == true && buttonClicks != 5)
        {
            Debug.Log("Succeeded current sequence! Next one...");
            correct = false;
            LevelLights[level - 1].GetComponent<Image>().color = transparent; // Sets level light active to show successes
            level++;
            StartCoroutine(DisplaySequence()); 
        }

        // If succeeded current sequence and this is the last (fifth) sequence
        if (buttonClicks == level && correct == true && buttonClicks == 5)
        {
            Debug.Log("You win!!!");
            win = true;
            StartCoroutine(ColorBlink(green));
        }
    }

    // All buttons blink if getting sequence wrong or complete puzzle
    IEnumerator ColorBlink(Color color)
    {
        yield return new WaitForSeconds(.25f); 
        // Blink 3 times
        for (int j = 0; j < 3; j++)
        {
            Debug.Log("Blink: " + j);
            for (int i = 0; i < Buttons.Length; i++)
                Buttons[i].GetComponent<Image>().color = color;
            for (int i = 0; i < LevelLights.Length; i++)
                LevelLights[i].GetComponent<Image>().color = color;

            yield return new WaitForSeconds(.5f);

            for (int i = 0; i < Buttons.Length; i++)
                Buttons[i].GetComponent<Image>().color = ButtonColors[i];
            for (int i = 0; i < LevelLights.Length; i++)
                LevelLights[i].GetComponent<Image>().color = white;

            yield return new WaitForSeconds(.5f); 
        }

        if (win == true )
        {
            // Win 
            Panel.SetActive(false); 
        }
    }



}
