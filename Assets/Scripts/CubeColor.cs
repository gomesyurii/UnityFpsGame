using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColor : Interactable
{
    [SerializeField] private GameObject cube;



    void Start()
    {
        
    }


    protected override void Interact()
    {
        base.Interact();
        cube.GetComponent<Renderer>().material.color = Random.ColorHSV();
    }
}
