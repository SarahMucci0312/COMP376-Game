using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueButton : MonoBehaviour, IInteractable
{
    private Animator colorButtonAnimator;
    
    public GameObject E;

    public void Start()
    {
        colorButtonAnimator = GetComponent<Animator>();
    }

    public void Interact()
    {
        if(!StateNameConptroller.bluePressed)
        {
            StateNameConptroller.bluePressed=true;
            colorButtonAnimator.Play("bluePressed", 0, 0.0f);
            Debug.Log("pressed blue");
            if(StateNameConptroller.Pressed1==false)
            {
                StateNameConptroller.Pressed1= true;
                StateNameConptroller.button1= "blue";
            }
            else
            {
                if(StateNameConptroller.Pressed2==false)
                {
                    StateNameConptroller.Pressed2= true;
                    StateNameConptroller.button2= "blue";
                }
                else
                {
                    if(StateNameConptroller.Pressed3==false)
                    {
                        StateNameConptroller.Pressed3= true;
                        StateNameConptroller.button3= "blue";
                    }
                    else
                    {
                        if(StateNameConptroller.Pressed4==false)
                        {
                            StateNameConptroller.Pressed4= true;
                            StateNameConptroller.button4= "blue";
                        }
                        else
                        {
                            if(StateNameConptroller.Pressed5==false)
                        {
                            StateNameConptroller.Pressed5= true;
                            StateNameConptroller.button5= "blue";
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
