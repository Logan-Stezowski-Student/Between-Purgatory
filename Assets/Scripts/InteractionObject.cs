using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractionObject : MonoBehaviour
{
    [SerializeField] private string interactionText = "Hello World";

    public UnityEvent OnInteract = new UnityEvent();

    private void OnEnable()
    {
        
    }
    public string GetInteractionText () 
    {
        return interactionText;
    }
    public void Interact() 
    {
        OnInteract.Invoke();
    }
}
