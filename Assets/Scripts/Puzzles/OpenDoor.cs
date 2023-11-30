using TMPro;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public MyDoorController doorScript;
    [SerializeField] GameObject text;
    private float currentTime = 0;
    private float destroyTime = 0;

    private void Start()
    {

    }

    void Update()
    {
        if (StateNameConptroller.p1Correct == true && StateNameConptroller.p1Solved == true && StateNameConptroller.doOnce == false)
        {
            doorScript.doorOpen = true;
            doorScript.PlayAnimation();
            StateNameConptroller.doOnce = true;
        }

        else if (StateNameConptroller.p1Correct == false && StateNameConptroller.p1Solved == true && StateNameConptroller.doOnce == false)
        {
            doorScript.doorOpen = true;
            doorScript.PlayAnimation();
            StateNameConptroller.doOnce = true;

            text.SetActive(true);
            currentTime = Time.time;
            destroyTime = Time.time + 5;

            
        }

        if (currentTime >= destroyTime)
        {
            text.SetActive(false);
        }

        else
        {
            currentTime += Time.deltaTime;
        }
        
    }
}
