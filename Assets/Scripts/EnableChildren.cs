using UnityEngine;

public class EnableChildren : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        if (StateNameConptroller.p1Solved == true)
        {
            gameObject.SetActive(false);
        }
    }
}
