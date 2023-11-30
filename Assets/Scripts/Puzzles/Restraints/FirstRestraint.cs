using UnityEngine;

public class FirstRestraint : MonoBehaviour
{
    public AudioSource restraintSound;
    void Update()
    {
        if (StateNameConptroller.p1Correct)
        {
            restraintSound.Play();
            gameObject.SetActive(false);
        }
    }
}
