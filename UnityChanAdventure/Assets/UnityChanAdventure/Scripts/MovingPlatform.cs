using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Vector3 startPos = transform.position;
        Vector3[] path =
        {
            new Vector3(0.0f, 0.0f, 0.0f) + startPos,
            new Vector3(0.0f, 3.0f, 0.0f) + startPos,
            new Vector3(3.0f, 3.0f, 0.0f) + startPos,
            new Vector3(3.0f, 0.0f, 0.0f) + startPos,
            new Vector3(0.0f, 0.0f, 0.0f) + startPos
        };
        rb.DOPath(path, 5.0f).SetEase(Ease.Linear).SetLoops(-1);
    }   
}
