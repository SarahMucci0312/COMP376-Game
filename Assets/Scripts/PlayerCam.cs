using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public Transform playerCam;
    public Vector2 sensitivity;
    private Vector2 xyRotation;
    public GameObject canvas;
    public canvasScript CanvasScript;
    [SerializeField] GameObject crosshair;
    void Start()
    {
        // Invisible cursor to the middle of the screen
        //Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        CanvasScript = canvas.GetComponent<canvasScript>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 MouseInput = new Vector2
        {
            x = Input.GetAxis("Mouse X"),
            y = Input.GetAxis("Mouse Y")
        };

        xyRotation.x -= MouseInput.y * sensitivity.y;
        xyRotation.y += MouseInput.x * sensitivity.x;

        xyRotation.x = Mathf.Clamp(xyRotation.x, -90f, 90f);
            if(!CanvasScript.paused)
            {
                transform.eulerAngles = new Vector3(0f, xyRotation.y, 0f);
                playerCam.localEulerAngles = new Vector3(xyRotation.x, 0f, 0f); 
        
            
                //Debug.Log(paused);
                xyRotation.x -= MouseInput.y * sensitivity.y;
                xyRotation.y += MouseInput.x * sensitivity.x;

                xyRotation.x = Mathf.Clamp(xyRotation.x, -90f, 90f);

                transform.eulerAngles = new Vector3(0f, xyRotation.y, 0f);
                playerCam.localEulerAngles = new Vector3(xyRotation.x, 0f, 0f); 

                StateNameConptroller.isPaused = false;
                
            }
            else
            {
                playerCam.localEulerAngles = new Vector3(0f, 0f, 0f); 
                StateNameConptroller.isPaused = true;

            }


        
        if (StateNameConptroller.isPaused)
        {
            crosshair.SetActive(false);
        }
        else
        {
            crosshair.SetActive(true);
        }


    }
}
