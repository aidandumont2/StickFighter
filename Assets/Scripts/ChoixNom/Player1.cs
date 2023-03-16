using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    float Position;
    GameObject Joueur1;
    void Start()
    {
        Position = GameManager.position1;
        Debug.Log("Position :" );
        Debug.Log(Position);
       
    }

    
    void Update()
    {
        
    }
}
