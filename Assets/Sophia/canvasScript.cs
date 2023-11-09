using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasScript : MonoBehaviour
{
    public Transform playerTransform;
    public float distanceFromPlayer = 0.5f;
    public GameObject pauseMenu;
    public bool paused = false;
    void Update()
    {
        // Calculate the canvas position in front of the player
        Vector3 canvasPosition = playerTransform.position + playerTransform.forward * distanceFromPlayer;
        transform.position = canvasPosition;

        // Make the canvas face the same direction as the player
        transform.forward = playerTransform.forward;

        if (Input.GetKeyDown(KeyCode.Escape) && paused)
        {
            paused = false;
            pauseMenu.SetActive(false);
            Time.timeScale = 1f;
            Cursor.visible = false;
        }

        else if (Input.GetKeyDown(KeyCode.Escape) && !paused)
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
            paused=true;
            Cursor.visible = true;
        }
    }
}
