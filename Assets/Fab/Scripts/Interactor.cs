using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IInteractable
{
    public void Interact();
    public void activateE();
    public void deactivateE();
}

public class Interactor : MonoBehaviour
{
    public Transform InteractorSource;
    public float InteractRange;
    private IInteractable previousInteractor;
    private IInteractable currentInteractor;

    void Start()
    {

    }

    void Update()
    {
        Ray r = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
    if (Physics.Raycast(r, out RaycastHit hit, InteractRange))
    {
        
        if (hit.collider.gameObject.TryGetComponent(out IInteractable interactObj))
        {
            if (interactObj != currentInteractor)
            {
                if (currentInteractor != null)
                {
                    currentInteractor.deactivateE();
                }
                currentInteractor = interactObj;
                currentInteractor.activateE();
            }
        }
        else
        {
            if (currentInteractor != null)
            {
                currentInteractor.deactivateE();
                currentInteractor = null;
            }
        }
    }
    else
    {
        if (currentInteractor != null)
        {
            currentInteractor.deactivateE();
            currentInteractor = null;
        }
    }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = new Ray(InteractorSource.position, InteractorSource.forward);
            if (Physics.Raycast(ray, out RaycastHit hitInfo, InteractRange))
            {
                if (hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactObj))
                {
                    interactObj.Interact();
                }
            }
        }

    }//End of Update() function
}