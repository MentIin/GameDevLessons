using System;
using UnityEngine;

public class Lesson3 : MonoBehaviour
{
    

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Я конснулся");
    }

    private void OnCollisionStay(Collision other)
    {
        Debug.Log("Лежит");
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
        }
        return;
        
    }

    private void OnDestroy()
    {
        
    }
}
