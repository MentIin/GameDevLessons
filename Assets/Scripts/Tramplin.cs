using System;
using UnityEngine;

public class Tramplin : MonoBehaviour
{
    public float force = 10.4f;
    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rigidbody = other.gameObject.GetComponent<Rigidbody>();

        rigidbody.mass = 1;
        
        // Vector3.up = new Vector3(0, 1, 0);
        rigidbody.linearVelocity = transform.up * force;
    }

    private void FixedUpdate()
    {
        
    }
}
