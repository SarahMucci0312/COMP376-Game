using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadButton4 : MonoBehaviour, IInteractable
{
    [SerializeField] GameObject button;
    private Renderer buttonRenderer;

    void Start()
    {
        buttonRenderer = button.GetComponent<Renderer>();
    }

    void Update()
    {
        if (StateNameConptroller.keypadPuzzleSolved)
        {
            buttonRenderer.material.SetColor("_Color", new Color(0f, 1f, 0f));
        }
    }



    public void Interact()
    {
        if (StateNameConptroller.keypadPuzzleSolved)
        {

        }

        else if (StateNameConptroller.currentPass == "261")
        {
            StateNameConptroller.currentPass = StateNameConptroller.currentPass + 4;
            StateNameConptroller.keypadPuzzleSolved = true;
        }

        else
        {
            StateNameConptroller.currentPass = "";
        }

        Debug.Log(StateNameConptroller.currentPass);
    }



    public void activateE()
    {

    }

    public void deactivateE()
    {

    }
}