using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoixBouton : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetButtonDown("Debug Vertical"))
        {
            float direction = Input.GetAxisRaw("Debug Vertical");
            if (direction * moveStep <= 1 && direction * moveStep >= -1)
            {
                if(direction <0) {
                    Movebas(direction * moveStep);
                    
                }
                Move(direction * moveStep);
                Debug.Log(direction);
            }
        }
    }
    public float moveStep = 0;
    private void Move(float distance)
    {
        //Debug.Log(transform.position);
        Debug.Log(distance);

        /// TODO: Modifier ce test pour que cela fonctionne avec un nombre pair d'animaux

        Vector3 newPosition = transform.position * distance + Vector3.up;
        Debug.Log(newPosition);

        /// TODO: Modifier ce test pour que cela fonctionne avec un nombre pair d'animaux
        if (Mathf.Abs(newPosition.y) <= 1 && Mathf.Abs(newPosition.y) >= -1)
        {
            transform.position = newPosition;
        }
    }
    private void Movebas(float distance)
    {
        //Debug.Log(transform.position);
        Debug.Log(distance);

        /// TODO: Modifier ce test pour que cela fonctionne avec un nombre pair d'animaux

        Vector3 newPosition = transform.position * distance + Vector3.down;
        Debug.Log(newPosition);

        /// TODO: Modifier ce test pour que cela fonctionne avec un nombre pair d'animaux
        if (Mathf.Abs(newPosition.y) <= 1 && Mathf.Abs(newPosition.y) >= -1)
        {
            transform.position = newPosition;
        }
    }
}
