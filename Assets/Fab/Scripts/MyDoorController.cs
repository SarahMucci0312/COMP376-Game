using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyDoorController : MonoBehaviour
{
    public Animator doorAnim;

    public bool doorOpen = false;

    private void Awake()
    {
        doorAnim = GetComponent<Animator>();
    }

    public void PlayAnimation()
    {
        if (doorOpen)
        {
            doorAnim.Play("OpenDoor", 0, 0.0f);
        }
    }
}
