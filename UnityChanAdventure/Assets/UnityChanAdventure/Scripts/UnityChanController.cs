using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UnityChanController : MonoBehaviour
{
    private Rigidbody rb;
    private float speed;
    private float rotationSpeed;
    private Vector2 moveInput;
    private Animator animator;
    private Interactable interactableObj;

    [SerializeField] private float moveSpeedConst = 5.0f;
    [SerializeField] private float rotationSpeedConst = 5.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        speed = moveInput.y * moveSpeedConst;
        rotationSpeed = moveInput.x * rotationSpeedConst;

        rb.velocity = transform.forward * speed + new Vector3(0f, rb.velocity.y, 0f);
        rb.angularVelocity = new Vector3(0, rotationSpeed, 0);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
        animator.SetFloat("speed", moveInput.y);
        animator.SetFloat("rotate", moveInput.x);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Interactable>(out var obj))
        {
            interactableObj = obj;
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.TryGetComponent<Interactable>(out var obj) && obj == interactableObj)
        {
            interactableObj = null;
        }
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            interactableObj?.Interact();
        }
    }
}