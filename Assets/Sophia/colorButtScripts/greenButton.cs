using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenButton : MonoBehaviour, IInteractable
{
    private Animator colorButtonAnimator;
    
    public GameObject E;

    
    public void Start()
    {
        colorButtonAnimator = GetComponent<Animator>();
    }

    public void Interact()
    {
        if(!StateNameConptroller.greenPressed)
        {
            StateNameConptroller.greenPressed=true;
            colorButtonAnimator.Play("greenPressed", 0, 0.0f);
            Debug.Log("pressed green");
            if(StateNameConptroller.Pressed1==false)
            {
                StateNameConptroller.Pressed1= true;
                StateNameConptroller.button1= "green";
            }
            else
            {
                if(StateNameConptroller.Pressed2==false)
                {
                    StateNameConptroller.Pressed2= true;
                    StateNameConptroller.button2= "green";
                }
                else
                {
                    if(StateNameConptroller.Pressed3==false)
                    {
                        StateNameConptroller.Pressed3= true;
                        StateNameConptroller.button3= "green";
                    }
                    else
                    {
                        if(StateNameConptroller.Pressed4==false)
                        {
                            StateNameConptroller.Pressed4= true;
                            StateNameConptroller.button4= "green";
                        }
                        else
                        {
                            if(StateNameConptroller.Pressed5==false)
                        {
                            StateNameConptroller.Pressed5= true;
                            StateNameConptroller.button5= "green";
                        }
                        else{}
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
