using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button2 : MonoBehaviour, IInteractable
{

    private Animator button;

    public void Start()
    {
        button = GetComponent<Animator>();
    }

    public void Interact()
    {
        if (StateNameConptroller.b1 == true && StateNameConptroller.b2 == false && StateNameConptroller.b3 == false)
        {
            button.Play("ButtonPress2", 0, 0.0f);
            StateNameConptroller.b2 = true;
            Debug.Log("Correct button");

        }

        else
        {
            button.Play("ButtonPress2", 0, 0.0f);
            StateNameConptroller.b1 = false;
            StateNameConptroller.b2 = false;
            StateNameConptroller.b3 = false;
            Debug.Log("Wrong button, reseting");

        }
    }
}
