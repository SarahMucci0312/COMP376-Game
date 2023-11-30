using UnityEngine;

public class EnableClue4 : MonoBehaviour
{
    void Update()
    {
        if (StateNameConptroller.p4Correct)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(true);

            }
        }
    }
}
