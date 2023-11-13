using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redButton : MonoBehaviour, IInteractable
{
    private Animator colorButtonAnimator;

    public void Start()
    {
        colorButtonAnimator = GetComponent<Animator>();
    }

    public void Interact()
    {
        if (StateNameConptroller.redPressed == false && StateNameConptroller.bluePressed == false && StateNameConptroller.yellowPressed == false && StateNameConptroller.greenPressed == false)
        {
            Debug.Log("pressed red");
            colorButtonAnimator.Play("red", 0, 0.0f);
            StateNameConptroller.redPressed = true;
            Debug.Log("Correct button");
        }

        else
        {
            Debug.Log("pressed red");
            colorButtonAnimator.Play("red", 0, 0.0f);
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
