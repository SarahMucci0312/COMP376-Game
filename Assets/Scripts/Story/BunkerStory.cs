using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BunkerStory : MonoBehaviour
{
    public TMP_Text line;
    public AudioSource sound;
    private int bunkerLineCount = 0;
    private float textSpeed = 0.04f;

    //Scripts
    private string[] bunkerScript = { "As soon as I enter the bunker, I hear her.",
                                      "Detective Bean: “Anna...!”",
                                      "Anna: “H-Help…Please…”",
                                      "She's restrained at the arms to a table in the center of the room.",
                                      "But she's alive- Thank god.",
                                      "Detective Bean: “Don't worry, I'm gonna get you out of-”",
                                      "Mysterious Voice:“Not so fast, detective.”",
                                      "Detective Bean: “You-!”",
                                      "This voice-",
                                      "Mysterious Voice: “It'd be a shame for this to end so quickly after all the prep-work I had to do.”",
                                      "Mysterious Voice: “Though, if you want to end this scene with a bang, I suppose that's alright as well.”",
                                      "-it's all too familiar.",
                                      "Detective Bean: “A bang? What do you-”",
                                      "Mysterious Voice: “But I'm sure you'd rather leave here with her alive, yes?”",
                                      "Anna: “I don't wanna die… I don't wanna die…”",
                                      "Anna...",
                                      "I knew it would happen eventually.",
                                      "In my profession, you get to know a lot of...unsavory individuals.",
                                      "It isn't uncommon for them to try gaining leverage in this way.",
                                      "Detective Bean: “What do you want? Why do this all the way out-”",
                                      "Mysterious Voice: “With my revenge nearly complete, I thought I'd challenge you to a duel, detective.”",
                                      "Mysterious Voice: “The rules are simple: If you can figure out my identity, you win.”",
                                      "Mysterious Voice: “Of course, I'll give you some hints. But you'll have to work for them.”",
                                      "Mysterious Voice: “Solve the games I've layed out for you in this room and you'll get your answers.”",
                                      "Mysterious Voice: “And your wife back.”",
                                      "Mysterious Voice: “The door will unlock automatically after you've attempted every puzzle.”",
                                      "Mysterious Voice: “If you got the majority of them correct, that is...”",
                                      "Mysterious Voice: “But I'll only let your wife go free if you ace them all.”",
                                      "Mysterious Voice: “Fail even one and, well…bang.”",
                                      "Mysterious Voice: “Don't worry though, I'll give you a few chances for each.”",
                                      "Mysterious Voice: “It'd be a shame to let all this work go to waste, after all.”",
                                      "Mysterious Voice: “So detective…Who am I?”",
                                      "So it was a recording...",
                                      "Detective Bean: “Don't worry, I promise that even when that door opens, I won't leave you behind.”",
                                      "Detective Bean: “I'll get you out of here alive.”",
                                      "Anna: “P-Promise?”",
                                      "Detective Bean: “Promise.”",
                                      "Detective Bean: “I’m going to check out these supposed ‘games’ that have been set up. So for now, just sit tight.”",
                                      ""
                                    };

    private void Start()
    {
        line.text = string.Empty;
        StartDialogue();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (line.text == bunkerScript[bunkerLineCount])
            {
                ChangeLine();
            }
            else
            {
                StopAllCoroutines();
                line.text =bunkerScript[bunkerLineCount];
            }
        }
    }

    private void StartDialogue()
    {
        bunkerLineCount = 0;
        StartCoroutine(ShowLine());
    }

    private IEnumerator ShowLine()
    {
        foreach (char c in bunkerScript[bunkerLineCount].ToCharArray())
        {
            line.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void ChangeLine()
    {
        if (bunkerLineCount < (bunkerScript.Length - 1))
        {
            bunkerLineCount++;
            line.text = string.Empty;
            if(bunkerLineCount == 6 ||
                bunkerLineCount == 9 ||
                bunkerLineCount == 10 ||
                bunkerLineCount == 13 ||
                bunkerLineCount == 20 ||
                bunkerLineCount == 21 ||
                bunkerLineCount == 22 ||
                bunkerLineCount == 23 ||
                bunkerLineCount == 24 ||
                bunkerLineCount == 25 ||
                bunkerLineCount == 26 ||
                bunkerLineCount == 27 ||
                bunkerLineCount == 28 ||
                bunkerLineCount == 29 ||
                bunkerLineCount == 30 ||
                bunkerLineCount == 31){
                sound.Play();
            }

            StartCoroutine(ShowLine());
        }
        else
        {
            SceneManager.LoadScene("Main");
            gameObject.SetActive(false);
        }
    }
}
