using System;
using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class Landmine : MonoBehaviour
{    
    public float explosionDelay;
    public float waitTime;


    private void OnTriggerEnter(Collider other)
    {
        TriggerLandmine();
    }

    private void Update()
    {
        Debug.Log("Some text");
        Debug.LogWarning("Some text warning");
        Debug.LogError("Some text error");
    }

    void TriggerLandmine()
    {
        transform.localScale = Vector3.one * 10f;
        StartCoroutine(Explode(explosionDelay));
    }
    
    private IEnumerator Explode(float explosionDelay)
    {
        yield return new WaitForSeconds(waitTime);
        
        InflictDamage();
        Destroy(this.gameObject);
    }

    private void InflictDamage()
    {
        RaycastHit[] sphereCastAll = Physics.SphereCastAll(
            transform.position, 10, Vector3.zero, 0f);
        // DESTROY ALL OBJECTS IN THE SPHERE
    }

    private void OnDrawGizmos()
    {
        
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position, 10f);
    }
}