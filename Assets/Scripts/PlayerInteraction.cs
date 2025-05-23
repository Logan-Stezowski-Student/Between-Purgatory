using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private Text interactionText;

    private InteractionObject targetInteraction;

    void Update()
    {

        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        
        string displayText = "";
        targetInteraction = null;
        if (other.gameObject.CompareTag("Door")) 
        {
            targetInteraction = other.gameObject.GetComponent<InteractionObject>();
            if (targetInteraction && targetInteraction.enabled)
            {
                displayText = targetInteraction.GetInteractionText();
            }
            SetInteractableNameText(displayText);
        }
        if (other.gameObject.CompareTag("Chest"))
        {

            targetInteraction = other.gameObject.GetComponent<InteractionObject>();
            if (targetInteraction && targetInteraction.enabled)
            {
                print(other.gameObject.tag);
                displayText = targetInteraction.GetInteractionText();
            }
            SetInteractableNameText(displayText);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        string displayText = "";
        targetInteraction = null;
        SetInteractableNameText (displayText);
    }
    private void SetInteractableNameText(string newText)
    {
        if (interactionText != null)
        {
            interactionText.text = newText;
        }
    }

    public void TryInteract()
    {
        if (targetInteraction != null && targetInteraction.enabled)
        {
            targetInteraction.Interact();
        }
    }
}