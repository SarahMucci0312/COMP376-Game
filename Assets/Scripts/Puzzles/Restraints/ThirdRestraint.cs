using UnityEngine;

public class ThirdRestraint : MonoBehaviour
{
    public AudioSource restraintSound;
    void Update()
    {
        if (StateNameConptroller.p3Correct)
        {
            restraintSound.Play();
            gameObject.SetActive(false);
        }
    }
}
