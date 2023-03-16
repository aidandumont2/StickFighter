using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoixNom : MonoBehaviour
{
    // Start is called before the first frame update
    float position1 = GameManager.position1;
    float position2 = GameManager.position2;
    public GameObject Joueur1;
    public GameObject Joueur2;
    void Start()
    {
        //Debug.Log(position1);
        //Debug.Log(position2);
        Joueur1.transform.position = new Vector3(position2,0,0);
        Joueur2.transform.position = new Vector3(position1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
