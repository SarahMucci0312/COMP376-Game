using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resumeScript : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject Canvas;
    public canvasScript CanvasScript;

    void Start()
    {
        CanvasScript = Canvas.GetComponent<canvasScript>();
    }
    public void onClick()
    {
        Cursor.visible = false;
        pauseMenu.SetActive(false);
        CanvasScript.paused=false;
        Time.timeScale = 1f;

    }
}
