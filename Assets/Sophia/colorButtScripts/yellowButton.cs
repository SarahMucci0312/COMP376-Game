using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellowButton : MonoBehaviour, IInteractable
{
    private Animator colorButtonAnimator;

    public void Start()
    {
        colorButtonAnimator = GetComponent<Animator>();
    }

    public void Interact()
    {
        if (StateNameConptroller.redPressed == true && StateNameConptroller.bluePressed == true && StateNameConptroller.yellowPressed == false && StateNameConptroller.greenPressed == false)
        {
            Debug.Log("pressed yellow");
            colorButtonAnimator.Play("yellow", 0, 0.0f);
            StateNameConptroller.yellowPressed = true;
            Debug.Log("Correct button");
        }

        else
        {
            Debug.Log("pressed yellow");
            colorButtonAnimator.Play("yellow", 0, 0.0f);
            StateNameConptroller.redPressed = false;
            StateNameConptroller.bluePressed = false;
            StateNameConptroller.yellowPressed = false;
            StateNameConptroller.greenPressed = false;
            Debug.Log("Wrong button, reseting");
        }
    }
    public void activateE()
    {
    }

    public void deactivateE()
    {
    }
}
