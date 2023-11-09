using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button3 : MonoBehaviour, IInteractable
{

    private Animator button;

    public void Start()
    {
        button = GetComponent<Animator>();
    }

    public void Interact()
    {
        if (StateNameConptroller.b1 == true && StateNameConptroller.b2 == true && StateNameConptroller.b3 == false)
        {
            button.Play("ButtonPress3", 0, 0.0f);
            StateNameConptroller.b3 = true;
            Debug.Log("Correct button");

        }

        else
        {
            button.Play("ButtonPress3", 0, 0.0f);
            StateNameConptroller.b1 = false;
            StateNameConptroller.b2 = false;
            StateNameConptroller.b3 = false;
            Debug.Log("Wrong button, reseting");

        }
    }
}
