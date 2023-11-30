using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateNameConptroller : MonoBehaviour
{
    //Puzzle correct count
    public static int correctlySolved = 0;
    public static int solved = 0;

    //Sarah puzzle
    public static bool p1Solved = false;
    public static bool p1Correct = false;
    public static int p1tries= 0;
    public static bool doOnce = false;
    public static bool p1Open = false;

    //Sophia puzzle
    public static bool p2Solved = false;
    public static bool p2Correct = false;
    public static int p2tries = 0;
    public static bool redPressed = false;
    public static bool bluePressed = false;
    public static bool yellowPressed = false;
    public static bool greenPressed = false;
    public static bool pinkPressed = false;
    public static bool orangePressed = false;
    public static bool brownPressed = false;
    public static bool whitePressed = false;
    public static bool blackPressed = false;
    public static bool Pressed1 = false;
    public static bool Pressed2 = false;
    public static bool Pressed3 = false;
    public static bool Pressed4 = false;
    public static bool Pressed5 = false;
    public static string button1 = "";
    public static string button2 = "";
    public static string button3 = "";
    public static string button4 = "";
    public static string button5 = "";

    //Hanae puzzle
    public static bool p3Solved = false;
    public static bool p3Correct = false;
    public static bool simonSaysPressed = false;

    //Crosshair
    public static bool isPaused = false;

    //Fabio puzzle
    public static bool p4Solved = false;
    public static bool p4Correct = false;
    public static int p4tries = 0;
    public static string pass = "2611";
    public static string currentPass = "";

}
