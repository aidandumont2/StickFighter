using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chargement : MonoBehaviour
{
    public GameObject Batman;
    public GameObject Dio;
    public GameObject Doomsday;
    public GameObject CaptainFalcon;
    public GameObject Flash;
    public GameObject ReverseFlash;

    [SerializeField]
    private Vector3 zonespawnJ1;

    // Start is called before the first frame update
    void Start()
    {
        print(GameManager.PersonnageJ1);
        print(GameManager.PersonnageJ2);
        if (GameManager.PersonnageJ1 == "Batman")
        {
            GameObject instantiated = Instantiate(Batman);
            instantiated.transform.position= zonespawnJ1;
            Gizmos.DrawWireCube(transform.position, zonespawnJ1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
