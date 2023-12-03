using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad : Interactable
{
   
    [SerializeField]private GameObject door;
    private bool isOpen = false;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    protected override void Interact()
    {
        isOpen = !isOpen;
        base.Interact();
        door.GetComponent<Animator>().SetBool("isOpen", isOpen);
        
    }

}
