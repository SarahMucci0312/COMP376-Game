using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle2 : MonoBehaviour
{
    public GameObject blueBut;
    public Animator blueAnim;
    public GameObject redBut;
    public Animator redAnim;
    public GameObject greenBut;
    public Animator greenAnim;
    public GameObject yellowBut;
    public Animator yellowAnim;
    public GameObject pinkBut;
    public Animator pinkAnim;
    public GameObject brownBut;
    public Animator brownAnim;
    public GameObject blackBut;
    public Animator blackAnim;
    public GameObject whiteBut;
    public Animator whiteAnim;
    public GameObject orangeBut;
    public Animator orangeAnim;

    public void Start()
    {
        redAnim = redBut.GetComponent<Animator>();
        blueAnim = blueBut.GetComponent<Animator>();
        greenAnim = greenBut.GetComponent<Animator>();
        yellowAnim = yellowBut.GetComponent<Animator>();
        pinkAnim = pinkBut.GetComponent<Animator>();
        brownAnim = brownBut.GetComponent<Animator>();
        blackAnim = blackBut.GetComponent<Animator>();
        whiteAnim = whiteBut.GetComponent<Animator>();
        orangeAnim = orangeBut.GetComponent<Animator>();
    }

    public void Update()
{
    if(StateNameConptroller.Pressed1==true && StateNameConptroller.Pressed2==true&& StateNameConptroller.Pressed3==true && StateNameConptroller.Pressed4==true && StateNameConptroller.Pressed5==true )
    {
        Debug.LogWarning("5 buttons pressed");
        if(StateNameConptroller.button1=="red"&&StateNameConptroller.button2=="blue"&& StateNameConptroller.button3=="yellow"&& StateNameConptroller.button4=="green" && StateNameConptroller.button5=="pink")
        {
            Debug.LogWarning("correct sequqence");
            StateNameConptroller.p2Solved = true;
        }
        else
        {
            Debug.LogWarning("wrong sequqence");
            StateNameConptroller.Pressed1 = false;
            StateNameConptroller.Pressed2 = false;
            StateNameConptroller.Pressed3 = false;
            StateNameConptroller.Pressed4 = false;
            StateNameConptroller.button1 = "";
            StateNameConptroller.button2 = "";
            StateNameConptroller.button3 = "";
            StateNameConptroller.button4 = "";
            redAnim.Play("redOff", 0, 0.0f);
            blueAnim.Play("blueOff", 0, 0.0f);
            greenAnim.Play("greenOff", 0, 0.0f);
            yellowAnim.Play("yellowOff", 0, 0.0f);
            pinkAnim.Play("pinkOff", 0, 0.0f);
            brownAnim.Play("brownOff", 0, 0.0f);
            blackAnim.Play("blackOff", 0, 0.0f);
            whiteAnim.Play("whiteOff", 0, 0.0f);
            orangeAnim.Play("orangeOff", 0, 0.0f);
            StateNameConptroller.redPressed = false;
            StateNameConptroller.bluePressed = false;
            StateNameConptroller.yellowPressed = false;
            StateNameConptroller.greenPressed = false;
            StateNameConptroller.pinkPressed = false;
            StateNameConptroller.brownPressed = false;
            StateNameConptroller.blackPressed = false;
            StateNameConptroller.whitePressed = false;
            StateNameConptroller.orangePressed = false;
        }
    }
}
}
