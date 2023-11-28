using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasScript : MonoBehaviour
{
    public Transform playerTransform;
    //public Transform camLookAt;
    public float distanceFromPlayer = 0.5f;
    public GameObject pauseMenu;
    public GameObject SimonSaysPanel;
    public bool paused = false;
    public int playerHeight = 1;
    void Update()
    {
        // Calculate the canvas position in front of the player
        Vector3 canvasPosition = playerTransform.position + playerTransform.forward * distanceFromPlayer;
        canvasPosition.y += playerHeight;
        transform.position = canvasPosition;

        // Make the canvas face the same direction as the player
        transform.forward = playerTransform.forward;

        if (Input.GetKeyDown(KeyCode.Escape) && paused)
        {
            Cursor.visible = false;
            paused = false;
            pauseMenu.SetActive(false);
            Time.timeScale = 1f;
        }

        else if (Input.GetKeyDown(KeyCode.Escape) && !paused)
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
            paused=true;
            Cursor.visible = true;
            //camLookAt.Rotation = new Vector3(0,0,0);
        }

        if (SimonSaysPanel.activeSelf == true)
        {
            Cursor.visible = true;
            paused = true; 
        }

        if (SimonSaysPanel.activeSelf == false)
        {
            Cursor.visible = false;
            paused = false;
        }
    }
}
