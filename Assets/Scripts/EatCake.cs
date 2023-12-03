using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatCake : Interactable
{
    [SerializeField] private GameObject cake;
    void Start()
    {

    }

    protected override void Interact()
    {
        base.Interact();
        Destroy(cake);
    } 
}
