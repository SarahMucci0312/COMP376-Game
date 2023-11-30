using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrueEnding : MonoBehaviour
{
    public TMP_Text line;
    private int lineCount = 0;
    private float time = 3;
    private float textSpeed = 0.04f;

    //Script
    private string[] trueEndingScript = {"When I stepped through the door, the bomb countdown started.",
                                         "Quickly, I grabbed Anna by the wrist and together, we made a run for it.",
                                         "Once we were finally outside of the blast radius, I asked her why she did it.",
                                         "“The murders or the duel?” She asked me, completely calm.",
                                         "“Both.” I said. “What was the point in any of this?!”",
                                         "“Well...”",
                                         "She explained that every one of those people had done something horrible to her family.",
                                         "Wendy hit her sister's car while drunk driving, killing her on impact.",
                                         "Mary physically and emotionally abused her brother throughout the entirety of their relationship.",
                                         "Simon set her childhood home on fire.",
                                         "And David scammed Anna's mom out of her life savings, ultimately leading her to commit suicide.",
                                         "According to Anna, they all got off with either minor repurcussions or none at all.",
                                         "And the kicker -this all happened the while she was studying abroad, out of reach.",
                                         "“It was as if, as soon as I went away, the whole family got cursed.” She told me with tears in her eyes.",
                                         "“So then...what was all this? Why did you call me to the bunker?”",
                                         "Anna smiled.",
                                         "“I never intended to leave here alive and...I figured...why not go out with a bang?” She laughed.",
                                         "And in spite of myself, I laughed too.",
                                         "I couldn't agree with what she had done, but I understood her desperation.",
                                         "Being unable to protect your loved ones...",
                                         "Having tragedy strike again and again...",
                                         "I can only imagine how angry and powerless she must have felt.",
                                         "“So...I guess you have to arrest me now, seeing as I didn't die in that explosion...”",
                                         "While holding her wrists out to be cuffed, she smiled bravely.",
                                         "“Just so you know, I'm grateful to you.”",
                                         "“For solving your puzzles?”",
                                         "“For listening. And...for saving me.”",
                                         "“Thank you.”",
                                         ""
                                        };

    private void Start()
    {
        line.text = string.Empty;
        StartCoroutine(Timer());
        StartDialogue();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (line.text == trueEndingScript[lineCount])
            {
                ChangeLine();
            }
            else
            {
                StopAllCoroutines();
                line.text = trueEndingScript[lineCount];
            }
        }
    }

    private void StartDialogue()
    {
        lineCount = 0;
        StartCoroutine(ShowLine());
    }

    private IEnumerator ShowLine()
    {
        foreach (char c in trueEndingScript[lineCount].ToCharArray())
        {
            line.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(time);
        StopAllCoroutines();
    }

    void ChangeLine()
    {
        if (lineCount < (trueEndingScript.Length - 1))
        {
            lineCount++;
            line.text = string.Empty;
            StartCoroutine(ShowLine());
        }
        else
        {
            SceneManager.LoadScene(4);
            gameObject.SetActive(false);
        }
    }
}
