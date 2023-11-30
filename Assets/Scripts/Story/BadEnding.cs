using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BadEnding : MonoBehaviour
{
    public TMP_Text line;
    private int lineCount = 0;
    private float time = 3;
    private float textSpeed = 0.04f;

    //Scripts
    private string[] badEndingScript = {"In the end, it was no use.",
                                        "I couldn't save anyone.",
                                        "I couldn't solve anything.",
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
            if (line.text == badEndingScript[lineCount])
            {
                ChangeLine();
            }
            else
            {
                StopAllCoroutines();
                line.text = badEndingScript[lineCount];
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
        foreach (char c in badEndingScript[lineCount].ToCharArray())
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
        if (lineCount < (badEndingScript.Length - 1))
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
