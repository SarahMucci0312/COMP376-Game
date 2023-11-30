using UnityEngine;

public class EnableChildren : MonoBehaviour
{
    private bool done = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && !done && !StateNameConptroller.p1Open)
        {
            StateNameConptroller.p1Open = true;
            Cursor.visible = true;
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(true);
            }
        }

        else if (Input.GetKeyDown(KeyCode.Tab) && !done && StateNameConptroller.p1Open)
        {
            Cursor.visible = false;
            StateNameConptroller.p1Open = false;
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(false);
            }
        }


        if (StateNameConptroller.p1Solved == true)
        {
            Cursor.visible = false;
            done = true;
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }
}
