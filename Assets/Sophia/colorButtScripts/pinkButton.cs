using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinkButton : MonoBehaviour, IInteractable
{
    private Animator colorButtonAnimator;
    
    public GameObject E;

    public void Start()
    {
        colorButtonAnimator = GetComponent<Animator>();
    }

    public void Interact()
    {
        if(!StateNameConptroller.pinkPressed)
        {
            StateNameConptroller.pinkPressed=true;
            colorButtonAnimator.Play("pinkPressed", 0, 0.0f);
            Debug.Log("pressed pink");
            if(StateNameConptroller.Pressed1==false)
            {
                StateNameConptroller.Pressed1= true;
                StateNameConptroller.button1= "pink";
            }
            else
            {
                if(StateNameConptroller.Pressed2==false)
                {
                    StateNameConptroller.Pressed2= true;
                    StateNameConptroller.button2= "pink";
                }
                else
                {
                    if(StateNameConptroller.Pressed3==false)
                    {
                        StateNameConptroller.Pressed3= true;
                        StateNameConptroller.button3= "pink";
                    }
                    else
                    {
                        if(StateNameConptroller.Pressed4==false)
                        {
                            StateNameConptroller.Pressed4= true;
                            StateNameConptroller.button4= "pink";
                        }
                    }
                }
            }
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
