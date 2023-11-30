using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections;

public class IntroStory : MonoBehaviour
{
    public TMP_Text line;
    public AudioSource sound;
    private int introLineCount = 0;
    private float time = 3;
    private float textSpeed = 0.04f;

    //Script
    private string[] introScript = {"Detective Bean: “This is the place.”",
                                    "The abandoned bunker on the outskirts of District 11.",
                                    "Last night, I received a message from an unknown number telling me to come here alone.",
                                    "So, I got in my car and just drove.",
                                    "I know what you're thinking.",
                                    "This isn't wise." ,
                                    "This is how people die in horror movies.",
                                    "But I have to see this through.",
                                    "For her.",
                                    "Detective Bean: “...Anna.”",
                                    "My wife went missing over a month ago.",
                                    "One morning, she just left for work and never returned home.",
                                    "The next day, I got a note in the mail.",
                                    "WAIT -in all caps. That's all it said.",
                                    "On the back was a crude drawing of an eye with the number 5 in the pupil.",
                                    "That's when I knew Anna hadn't left of her own volition.",
                                    "Detective Bean: “I'm here.”",
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
            if(line.text == introScript[introLineCount])
            {
                ChangeLine();
            }
            else
            {
                StopAllCoroutines();
                line.text = introScript[introLineCount];
            }
        }
    }

    private void StartDialogue()
    {
        introLineCount = 0;
        StartCoroutine(ShowLine());
    }

    private IEnumerator ShowLine()
    {
        foreach(char c in introScript[introLineCount].ToCharArray())
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
        if (introLineCount < (introScript.Length - 1))
        {
            introLineCount++;
            line.text = string.Empty;
            StartCoroutine(ShowLine());
        }
        else
        {
            sound.Play();
            SceneManager.LoadScene("BunkerScene");
            gameObject.SetActive(false);
        }
    }

}
