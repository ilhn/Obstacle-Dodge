using System;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float timeToWait = 5f;
    
    MeshRenderer droppingObjectMeshRenderer;
    Rigidbody droppingObjectRigidbody;

    void Start()
    {
        droppingObjectMeshRenderer = GetComponent<MeshRenderer>();
        droppingObjectRigidbody = GetComponent<Rigidbody>();
        
        droppingObjectMeshRenderer.enabled = false;
        droppingObjectRigidbody.useGravity = false;
    }
    void Update()
    {
        if (Time.time > timeToWait)
        {
            droppingObjectMeshRenderer.enabled = true;
            droppingObjectRigidbody.useGravity = true;
        }
    }
}
