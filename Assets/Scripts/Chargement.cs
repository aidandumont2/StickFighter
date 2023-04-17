using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Image = UnityEngine.UI.Image;

public class Chargement : MonoBehaviour
{
    public GameObject Batman;
    public GameObject Dio;
    public GameObject Doomsday;
    public GameObject Akuma;
    public GameObject Flash;
    public GameObject ReverseFlash;
    public GameObject BatmanSwap;
    public GameObject DioSwap;
    public GameObject DoomsdaySwap;
    public GameObject AkumaSwap;
    public GameObject FlashSwap;
    public GameObject ReverseFlashSwap;

    [SerializeField]
    private Vector3 zonespawnJ1;
    [SerializeField]
    private Vector3 zonespawnJ2;

    // Start is called before the first frame update
    void Start()
    {
        AssignationJ1();
        AssignationJ2();
    }
    public void AssignationJ2()
    {
        if (GameManager.PersonnageJ2 == "Batman")
        {
            assignationPersonnage2(BatmanSwap);
        }
        if (GameManager.PersonnageJ2 == "Dio")
        {
            assignationPersonnage2(DioSwap);
        }
        if (GameManager.PersonnageJ2 == "Doomsday")
        {
            assignationPersonnage2(DoomsdaySwap);
        }
        if (GameManager.PersonnageJ2 == "Akuma")
        {
            assignationPersonnage2(AkumaSwap);
        }
        if (GameManager.PersonnageJ2 == "Flash")
        {
            assignationPersonnage2(FlashSwap);
        }
        if (GameManager.PersonnageJ2 == "ReverseFlash")
        {
            assignationPersonnage2(ReverseFlashSwap);
        }
    }
    public void assignationPersonnage1(GameObject other)
    {
        GameObject instantiated = Instantiate(other);
        instantiated.transform.position = new Vector3(-4.427015f, -2.85f, 0);
        AssignationJ2();
        Gizmos.DrawWireCube(transform.position, zonespawnJ1);
    }
    public void AssignationJ1()
    {
        if (GameManager.PersonnageJ1 == "Batman")
        {
            assignationPersonnage1(Batman);
            AssignationJ2();
        }
        if (GameManager.PersonnageJ1 == "Dio")
        {
            assignationPersonnage1(Dio);
            AssignationJ2();
        }
        if (GameManager.PersonnageJ1 == "Doomsday")
        {
            assignationPersonnage1(Doomsday);
            AssignationJ2();
        }
        if (GameManager.PersonnageJ1 == "Akuma")
        {
            assignationPersonnage1(Akuma);
            AssignationJ2();
        }
        if (GameManager.PersonnageJ1 == "Flash")
        {
            assignationPersonnage1(Flash);
            AssignationJ2();
        }
        if (GameManager.PersonnageJ1 == "ReverseFlash")
        {
            assignationPersonnage1(ReverseFlash);
            AssignationJ2();
        }
    }
    public void assignationPersonnage2(GameObject other)
    {
        GameObject instantiated = Instantiate(other);
        instantiated.transform.position = new Vector3(4.36f, -3.2f, -4.382038f);
       // Gizmos.DrawWireCube(transform.position, zonespawnJ2);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(GameManager.PersonnageJ1);
        Debug.Log(GameManager.PersonnageJ2);
    }
}
