using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoodEnding : MonoBehaviour
{
    public TMP_Text line;
    private int lineCount = 0;
    private float time = 3;
    private float textSpeed = 0.04f;

    //Scripts
    private string[] goodEndingScript = {"When I stepped through the door, the bomb countdown started.",
                                         "Anna laughed.",
                                         "She told me that she expected as much and not to worry.",
                                         "She was just getting what she deserved.",
                                         "I asked her why she did it.",
                                         "But all she did was laugh and tell me to get lost.",
                                         "...",
                                         "Anna...",
                                         "Why did you do this?",
                                         "Why did you kill those people?",
                                         "Why did you set up this elaborate scheme just to confess and leave me behind?",
                                         "I don't think I'll ever know.",
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
            if (line.text == goodEndingScript[lineCount])
            {
                ChangeLine();
            }
            else
            {
                StopAllCoroutines();
                line.text = goodEndingScript[lineCount];
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
        foreach (char c in goodEndingScript[lineCount].ToCharArray())
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
        if (lineCount < (goodEndingScript.Length - 1))
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
