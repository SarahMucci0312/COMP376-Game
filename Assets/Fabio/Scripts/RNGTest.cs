using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RNGTest : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Debug.Log(Random.Range(0,100));
    }
    public void activateE()
    {
    }

    public void deactivateE()
    {
    }
}
