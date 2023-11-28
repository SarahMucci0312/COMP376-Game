using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimonSaysInteract : MonoBehaviour, IInteractable
{

    public GameObject E;
    public GameObject Panel;


    public void Interact()
    {
        if (!StateNameConptroller.simonSaysPressed)
        {
            Debug.Log("Simon Says computer pressed"); 
            StateNameConptroller.simonSaysPressed = true;
            Panel.SetActive(true); 
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
