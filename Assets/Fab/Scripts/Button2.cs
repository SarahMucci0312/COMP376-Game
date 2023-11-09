using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button2 : MonoBehaviour, IInteractable
{

    private Animator button;
    public GameObject E;

    public void Start()
    {
        button = GetComponent<Animator>();
    }

    public void Interact()
    {
        if (StateNameConptroller.b1 == true && StateNameConptroller.b2 == false && StateNameConptroller.b3 == false)
        {
            Debug.Log("pressed button2");
            button.Play("ButtonPress2", 0, 0.0f);
            StateNameConptroller.b2 = true;
            Debug.Log("Correct button");

        }

        else
        {
            Debug.Log("pressed button2");
            button.Play("ButtonPress2", 0, 0.0f);
            StateNameConptroller.b1 = false;
            StateNameConptroller.b2 = false;
            StateNameConptroller.b3 = false;
            Debug.Log("Wrong button, reseting");

        }
    }
    public void activateE()
    {
        E.SetActive(true);
    }

    public void deactivateE()
    {
        E.SetActive(false);
    }
}
