using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimonSaysInteract : MonoBehaviour, IInteractable
{

    public GameObject E;
    public GameObject Panel;

    void Update()
    {
        if (Panel.activeSelf == true)
        {
            Cursor.visible = true;        }

        if (Panel.activeSelf == false)
        {
            Cursor.visible = false;
        }
    }

    public void Interact()
    {
        if (!StateNameConptroller.simonSaysPressed && !StateNameConptroller.p3Solved) 
        {
            Debug.Log("Simon Says computer pressed"); 
            StateNameConptroller.simonSaysPressed = true;
            StateNameConptroller.isPaused = true;
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
