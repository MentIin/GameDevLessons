using System;
using UnityEngine;

public class Raycast : MonoBehaviour
{

    public LayerMask layerMask;
    private void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        
        RaycastHit hit;

        bool isHittedSomething = Physics.Raycast(ray, out hit, 5f, layerMask);
        if (isHittedSomething)
        {
            Debug.Log(hit.normal);
            Debug.Log(hit.collider.gameObject.name);
        }

        /*Physics.SphereCast(transform.position, 0.5f, transform.forward, out hit);
        Physics.BoxCast();
        Physics.CapsuleCast();
        Physics.RaycastAll()*/
    }
}
