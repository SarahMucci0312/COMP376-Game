using UnityEngine;

public class EnableClue2 : MonoBehaviour
{
    void Update()
    {
        if (StateNameConptroller.p2Correct)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(true);

            }
        }
    }
}
