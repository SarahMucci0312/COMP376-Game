using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections;

public class Story : MonoBehaviour
{
    public TMP_Text line;
    public AudioSource sound;
    private int introLineCount = 0;
    private int bunkerLineCount = 0;
    private bool doneTalking = false;
    private float time = 3;

    //Scripts
    private string[] introScript = {"Detective Bean: “This is the place.”", "Detective Bean: “...”", ""};
    private string[] bunkerScript = { "Detective Bean: “[Hostage]…?”",
                                      "[Hostage]: “H-Help…Please…”",
                                      "Detective Bean: “Don’t worry, I’m gonna get you out of-”",
                                      "Mysterious Voice:“Not so fast, detective.”",
                                      "Detective Bean: “What…?”",
                                      "Mysterious Voice: “It’d be a shame for this to end so quickly after all the prep-work I had to do.”",
                                      "Mysterious Voice: “Though, if you want to end this scene with a bang, I suppose that’s alright as well.”",
                                      "Detective Bean: “A bang? What do you-”",
                                      "Mysterious Voice: “But I’m sure you’d rather leave here with them alive, yes?”",
                                      "[Hostage]: “I don’t wanna die… I don’t wanna die…”",
                                      "Mysterious Voice: “To save [Hostage], you must complete all of the games I’ve set up for you in this room.”",
                                      "Mysterious Voice: “Each game is directly linked to a restraint on one of [Hostage]’s limbs. Successfully complete a game, and the linked limb will pop free.”",
                                      "Mysterious Voice: “Fail and, well…bang.”",
                                      "Mysterious Voice: “Don’t worry though, I’ll give you a few chances. It’d be a shame to let all this work go to waste, after all.”",
                                      "Mysterious Voice: “Once you’ve either freed [Hostage] or they’ve succumbed to a more *unfortunate* fate, you’ll need to answer my initial riddle in order to open the door.”",
                                      "Mysterious Voice: “All the information you need is in this room.”",
                                      "Mysterious Voice: “So detective…Who am I?”",
                                      "Detective Bean: “Don’t worry, I promise I’ll get you out of here alive.”",
                                      "Detective Bean: “But to do that, I’m going to need your help.”",
                                      "[Hostage]: “O-Okay.”",
                                      "Detective Bean: “Good. I’m going to check out these supposed ‘games’ that have been set up. So for now, just sit tight.”",
                                      ""
                                    };
    private string[] ending1Script = {"Detective Bean: “It’s no use…”", "Detective Bean: “I’m-”" };
    private string[] ending2Script = { "End 2" };

    private void Update()
    {
        if (doneTalking)
        {
            StartCoroutine(Timer());
            SceneManager.LoadScene(1);
        }
    }

    public void changeLine()
    {
        if (gameObject.CompareTag("IntroScene"))
        {
            line.text = bunkerScript[introLineCount];
            if (introLineCount < (bunkerScript.Length - 1))
            {
                introLineCount++;
            }
            else if(introLineCount == (bunkerScript.Length - 1))
            {
                sound.Play();
                doneTalking = true;
            }
        }

        if (gameObject.CompareTag("Bunker"))
        {
            line.text = introScript[bunkerLineCount];
            if(bunkerLineCount == 0)
            {
                sound.Play();
            }
            else if (bunkerLineCount < (bunkerScript.Length - 1))
            {
                bunkerLineCount++;
                if(bunkerLineCount == 15)
                {
                    for (int i = 0; i < transform.childCount; i++)
                    {
                        transform.GetChild(i).gameObject.SetActive(true);
                    }
                }
            }
            else
            {
                sound.Stop();
            }
        }
    }

    //Timer
    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(time);
        StopAllCoroutines();
    }

}
