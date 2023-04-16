using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choixcamp: MonoBehaviour
{
    public string joueurs = "";
    private void Update()
    {

        if (Input.GetButtonDown(joueurs)  )
        {
            float direction = Input.GetAxisRaw(joueurs);
            if (direction * moveStep <=6 && direction * moveStep >= -6)
            {
                Move(direction * moveStep);
                Debug.Log(joueurs);
            }
        }
    }
    public float moveStep = 0;
    private void Move(float distance)
    {
        Vector3 newPosition = transform.position + distance * Vector3.right;
        
        if (Mathf.Abs(newPosition.x) <= 6 && Mathf.Abs(newPosition.x) >= -6)
        {
            transform.position = newPosition;
        }
    }
}
