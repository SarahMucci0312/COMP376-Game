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

    public GameObject block1;
    public block1 b1Script;

    public GameObject block2;
    public block2 b2Script;

    public GameObject block3;
    public block3 b3Script;
    
    public GameObject block4;
    public block4 b4Script;

    public GameObject block5;
    public block5 b5Script;

    public GameObject denied;
    public GameObject granted;

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

        b1Script = block1.GetComponent<block1>();
        b2Script = block2.GetComponent<block2>();
        b3Script = block3.GetComponent<block3>();
        b4Script = block4.GetComponent<block4>();
        b5Script = block5.GetComponent<block5>();

    }

    public void Update()
{
    if(StateNameConptroller.Pressed1==true)
    {
        if(StateNameConptroller.button1=="red")
        {
            b1Script.color = StateNameConptroller.button1;
        }
        if(StateNameConptroller.button1=="blue")
        {
            b1Script.color = StateNameConptroller.button1;
        }
        if(StateNameConptroller.button1=="green")
        {
            b1Script.color = StateNameConptroller.button1;
        }
        if(StateNameConptroller.button1=="yellow")
        {
            b1Script.color = StateNameConptroller.button1;
        }
        if(StateNameConptroller.button1=="pink")
        {
            b1Script.color = StateNameConptroller.button1;
        }
        if(StateNameConptroller.button1=="orange")
        {
            b1Script.color = StateNameConptroller.button1;
        }
        if(StateNameConptroller.button1=="brown")
        {
            b1Script.color = StateNameConptroller.button1;
        }
        if(StateNameConptroller.button1=="black")
        {
            b1Script.color = StateNameConptroller.button1;
        }
        if(StateNameConptroller.button1=="white")
        {
            b1Script.color = "white";
        }
    }
    else
    {
        b1Script.color = "default";
        b2Script.color = "default";
        b3Script.color = "default";
        b4Script.color = "default";
        b5Script.color = "default";
    }

    if(StateNameConptroller.Pressed2==true)
    {
        if(StateNameConptroller.button2=="red")
        {
            b2Script.color = StateNameConptroller.button2;
        }
        if(StateNameConptroller.button2=="blue")
        {
            b2Script.color = StateNameConptroller.button2;
        }
        if(StateNameConptroller.button2=="green")
        {
            b2Script.color = StateNameConptroller.button2;
        }
        if(StateNameConptroller.button2=="yellow")
        {
            b2Script.color = StateNameConptroller.button2;
        }
        if(StateNameConptroller.button2=="pink")
        {
            b2Script.color = StateNameConptroller.button2;
        }
        if(StateNameConptroller.button2=="orange")
        {
            b2Script.color = StateNameConptroller.button2;
        }
        if(StateNameConptroller.button2=="brown")
        {
            b2Script.color = StateNameConptroller.button2;
        }
        if(StateNameConptroller.button2=="black")
        {
            b2Script.color = StateNameConptroller.button2;
        }
        if(StateNameConptroller.button2=="white")
        {
            b2Script.color = "white";
        }
    }

    if(StateNameConptroller.Pressed3==true)
    {
        if(StateNameConptroller.button3=="red")
        {
            b3Script.color = StateNameConptroller.button3;
        }
        if(StateNameConptroller.button3=="blue")
        {
            b3Script.color = StateNameConptroller.button3;
        }
        if(StateNameConptroller.button3=="green")
        {
            b3Script.color = StateNameConptroller.button3;
        }
        if(StateNameConptroller.button3=="yellow")
        {
            b3Script.color = StateNameConptroller.button3;
        }
        if(StateNameConptroller.button3=="pink")
        {
            b3Script.color = StateNameConptroller.button3;
        }
        if(StateNameConptroller.button3=="orange")
        {
            b3Script.color = StateNameConptroller.button3;
        }
        if(StateNameConptroller.button3=="brown")
        {
            b3Script.color = StateNameConptroller.button3;
        }
        if(StateNameConptroller.button3=="black")
        {
            b3Script.color = StateNameConptroller.button3;
        }
        if(StateNameConptroller.button3=="white")
        {
            b3Script.color = "white";
        }
    }

    if(StateNameConptroller.Pressed4==true)
    {
        if(StateNameConptroller.button4=="red")
        {
            b4Script.color = StateNameConptroller.button4;
        }
        if(StateNameConptroller.button4=="blue")
        {
            b4Script.color = StateNameConptroller.button4;
        }
        if(StateNameConptroller.button4=="green")
        {
            b4Script.color = StateNameConptroller.button4;
        }
        if(StateNameConptroller.button4=="yellow")
        {
            b4Script.color = StateNameConptroller.button4;
        }
        if(StateNameConptroller.button4=="pink")
        {
            b4Script.color = StateNameConptroller.button4;
        }
        if(StateNameConptroller.button4=="orange")
        {
            b4Script.color = StateNameConptroller.button4;
        }
        if(StateNameConptroller.button4=="brown")
        {
            b4Script.color = StateNameConptroller.button4;
        }
        if(StateNameConptroller.button4=="black")
        {
            b4Script.color = StateNameConptroller.button4;
        }
        if(StateNameConptroller.button4=="white")
        {
            b4Script.color = "white";
        }
    }

    if(StateNameConptroller.Pressed5==true)
    {
        if(StateNameConptroller.button5=="red")
        {
            b5Script.color = StateNameConptroller.button5;
        }
        if(StateNameConptroller.button5=="blue")
        {
            b5Script.color = StateNameConptroller.button5;
        }
        if(StateNameConptroller.button5=="green")
        {
            b5Script.color = StateNameConptroller.button5;
        }
        if(StateNameConptroller.button5=="yellow")
        {
            b5Script.color = StateNameConptroller.button5;
        }
        if(StateNameConptroller.button5=="pink")
        {
            b5Script.color = StateNameConptroller.button5;
        }
        if(StateNameConptroller.button5=="orange")
        {
            b5Script.color = StateNameConptroller.button5;
        }
        if(StateNameConptroller.button5=="brown")
        {
            b5Script.color = StateNameConptroller.button5;
        }
        if(StateNameConptroller.button5=="black")
        {
            b5Script.color = StateNameConptroller.button5;
        }
        if(StateNameConptroller.button5=="white")
        {
            b5Script.color = "white";
        }
    }

    if(StateNameConptroller.Pressed1==true && StateNameConptroller.Pressed2==true&& StateNameConptroller.Pressed3==true && StateNameConptroller.Pressed4==true && StateNameConptroller.Pressed5==true )
    {
        Debug.LogWarning("5 buttons pressed");
        if(StateNameConptroller.button1=="red"&&StateNameConptroller.button2=="blue"&& StateNameConptroller.button3=="yellow"&& StateNameConptroller.button4=="green" && StateNameConptroller.button5=="pink")
        {
            Debug.LogWarning("correct sequqence");
            StateNameConptroller.p2Solved = true;
            denied.SetActive(false);
            granted.SetActive(true);
        }
        else
        {
            Debug.LogWarning("wrong sequqence");
            StateNameConptroller.Pressed1 = false;
            StateNameConptroller.Pressed2 = false;
            StateNameConptroller.Pressed3 = false;
            StateNameConptroller.Pressed4 = false;
            StateNameConptroller.Pressed5 = false;
            StateNameConptroller.button1 = "";
            StateNameConptroller.button2 = "";
            StateNameConptroller.button3 = "";
            StateNameConptroller.button4 = "";
            StateNameConptroller.button5 = "";
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
