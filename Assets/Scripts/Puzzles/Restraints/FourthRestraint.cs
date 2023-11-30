using UnityEngine;

public class FourthRestraint : MonoBehaviour
{
    public AudioSource restraintSound;
    void Update()
    {
        if (StateNameConptroller.p4Correct)
        {
            restraintSound.Play();
            gameObject.SetActive(false);
        }
    }
}
