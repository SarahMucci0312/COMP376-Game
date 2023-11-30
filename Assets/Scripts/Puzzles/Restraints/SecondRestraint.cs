using UnityEngine;

public class SecondRestraint : MonoBehaviour
{
    public AudioSource restraintSound;
    void Update()
    {
        if (StateNameConptroller.p2Correct)
        {
            restraintSound.Play();
            gameObject.SetActive(false);
        }
    }
}
