using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool bClicked = false;
        RaycastHit rayCastHit;

        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger) || Input.GetMouseButtonDown(0))
        {
            bClicked = true;
        }

        if (Physics.Raycast(new Ray (transform.position, transform.forward), out rayCastHit, Mathf.Infinity))
        {
            GameObject target = rayCastHit.collider.gameObject;
            Interactable interactable = target.GetComponent<Interactable>();
            if (interactable != null)
            {
                interactable.Down();
                if (bClicked)
                {
                    interactable.Clicked();
                }
            }
        }
        
    }
}
