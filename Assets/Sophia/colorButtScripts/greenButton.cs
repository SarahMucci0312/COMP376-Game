using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenButton : MonoBehaviour, IInteractable
{
    private Animator colorButtonAnimator;

    public void Start()
    {
        colorButtonAnimator = GetComponent<Animator>();
    }

    public void Interact()
    {
        if (StateNameConptroller.redPressed == true && StateNameConptroller.bluePressed == true && StateNameConptroller.yellowPressed == true && StateNameConptroller.greenPressed == false)
        {
            Debug.Log("pressed green");
            colorButtonAnimator.Play("green", 0, 0.0f);
            StateNameConptroller.greenPressed = true;
            Debug.Log("Correct button");
        }

        else
        {
            Debug.Log("pressed green");
            colorButtonAnimator.Play("green", 0, 0.0f);
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
