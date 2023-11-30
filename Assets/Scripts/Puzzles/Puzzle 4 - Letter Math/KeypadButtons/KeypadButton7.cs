using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadButton7 : MonoBehaviour, IInteractable
{
    [SerializeField] GameObject button;
    private Renderer buttonRenderer;

    void Start()
    {
        buttonRenderer = button.GetComponent<Renderer>();
    }

    void Update()
    {
        if (StateNameConptroller.p4Solved && StateNameConptroller.p4Correct)
        {
            buttonRenderer.material.SetColor("_Color", new Color(0f, 1f, 0f));
        }

        else if (StateNameConptroller.p4Solved && !StateNameConptroller.p4Correct)
        {
            buttonRenderer.material.SetColor("_Color", new Color(1f, 0f, 0f));

        }
    }


    public void Interact()
    {
        if (!StateNameConptroller.p4Solved)
        {
            StateNameConptroller.currentPass = StateNameConptroller.currentPass + 7;

        }



    }



    public void activateE()
    {

    }

    public void deactivateE()
    {

    }
}