using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseScript : MonoBehaviour
{
    public GameObject pauseMenu;
    public void onClick()
    {
        pauseMenu.SetActive(true);
        Cursor.visible = true;
        StateNameConptroller.isPaused = true;

    }
}
