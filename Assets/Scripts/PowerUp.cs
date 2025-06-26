using System;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public AudioSource AudioSource;
    private void OnTriggerEnter(Collider other)
    {
        AudioSource.Play();
        other.transform.localScale = Vector3.one * 10f;
        other.transform.localScale = new Vector3(10f, 10f, 10f);
        other.transform.localScale = new Vector3(1f, 1f, 1f) * 10f;
        // Увеличиваем размер объекта, который вошел в триггер
    }

    private void OnTriggerExit(Collider other)
    {
        other.transform.localScale = Vector3.one;
    }
}
