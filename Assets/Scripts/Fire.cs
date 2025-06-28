using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public ParticleSystem fireParticleSystem;

    public GameObject prefab;

    Vector2Int gridSize = new Vector2Int(10, 10);
    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            fireParticleSystem.Play();
        }

        if (fireParticleSystem.isPlaying)
        {
            fireParticleSystem.Stop();
        }
        
    }

    private void Start()
    {
        StartCoroutine(MyCoroutine());
        Direction myEnum = Direction.North;
        int enumValue = (int)myEnum;

        Vector3 pos = new Vector3();
        Instantiate(prefab, pos, Quaternion.identity);
    }

    private IEnumerator MyCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(.5f);
            // do something every 0.5 seconds
            if (Input.GetKey(KeyCode.LeftShift))
            {
                // do something when left shift is pressed
            }
        }
    }
}

public struct Position
{
    public int x;
    public  int y;
}