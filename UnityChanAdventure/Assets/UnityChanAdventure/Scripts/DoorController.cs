using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour, Interactable
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Interact()
    {
        animator.SetTrigger("OpenClose");
    }
}